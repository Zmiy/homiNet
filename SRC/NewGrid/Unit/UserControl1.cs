using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unit
{
    public partial class uscUnit: UserControl
    {
        public uscUnit()
        {
            InitializeComponent();
        }


        public uscUnit(DataTable dt)
            : this()
        {
            ProductsSource = dt.Copy();
            cmbUnit.DisplayMember = "nom2";
            cmbUnit.ValueMember = "nom1";
            cmbUnit.DataSource = dtProducts;
            
        }

        public static Size Dimention = (new uscUnit()).Size;
        private DataTable dtProducts = new DataTable();
        private Dictionary<string, int> dicProducts = new Dictionary<string, int>();


        public int cmbLastSelectedIndex
        {
            get;
            set;
        }

        public String NumberOfList
        {
            get
            {
                return grbUnit.Text;
            }
            set
            {
                grbUnit.Text = value;
            }
        }

        private int nudCurrValue
        {
            get;
            set;
        }

        public static Size Dim
        {
            get
            {
                return (new uscUnit()).Size;
            }
        }

        public Boolean nudUnitVisible
        {
            get
            {
                return nudUnit.Visible;
            }
            set
            {
                nudUnit.Visible = value;
                grbUnit.Height = btnUnit.Height + 20 + (nudUnit.Visible == true ? nudUnit.Height : 0);
                Height = grbUnit.Height + 10;
                Dimention = new Size(Width, Height);
            }
        }

        public int maxValueOfUnit
        {
            get
            {
                return Convert.ToInt32(nudUnit.Value);
            }
            set
            {
                nudUnit.Value = value;
            }
        }

        public int CmbSelectedIndex
        {
            get
            {
                return cmbUnit.SelectedIndex;
            }
            set
            {
                cmbUnit.SelectedIndex = value;
            }
        }

        public string CmbSelectedValue
        {
            get
            {
                if (cmbUnit.SelectedIndex == 0)
                {
                    return "";
                }
                else
                {
                    return (string)cmbUnit.SelectedValue;
                }
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    value = "Not use";
                }
                if (cmbUnit.SelectedValue == null)
                    return;
                cmbUnit.SelectedValue = value;
                cmbLastSelectedIndex = cmbUnit.SelectedIndex;
                //cmbUnit.SelectedIndex = iSelectedIndex;
            }
        }

        public DataTable ProductsSource
        {
            set
            {

                dtProducts = value.Copy();
                DataRow dr = dtProducts.NewRow();
                dr[0] = "Not use";
                dr[1] = "Not use";
                dr[2] = "Not use";
                dtProducts.Rows.InsertAt(dr, 0);
                cmbUnit.DataSource = dtProducts;
            }

        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            cmbUnit.SelectedIndex = CmbSelectedIndex;
            cmbUnit.DroppedDown = true;
            btnUnit.Visible = false;
        }



        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGridUnit();
        }



        private void cmbUnit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            SetGridUnit();
        }


        private void cmbUnit_MouseUp(object sender, MouseEventArgs e)
        {
            SetGridUnit();
        }

        private void SetGridUnit()
        {
            
            if (cmbUnit.SelectedIndex < 0)
            {
                cmbUnit.SelectedIndex = 0;

            }
            cmbLastSelectedIndex = cmbUnit.SelectedIndex;
            btnUnit.Text = cmbUnit.Text.ToString();
            Color currBtnColor = btnUnit.BackColor;
            //nudUnit.Value=(From p In dtProducts.AsEnumerable())
            var qnt = (from prod in dtProducts.AsEnumerable() where prod.Field<String>("nom1")==cmbUnit.SelectedValue.ToString() select  prod.Field<string>("quantity")).ToArray();
            
            if (qnt.Length >0)
            {
                nudUnit.Value = Convert.ToDecimal(qnt[0]);

            }
            else
            {
                nudUnit.Value = 0;
            }

            if (cmbUnit.SelectedIndex > 0)
            {
                currBtnColor = Color.LawnGreen;
                if (nudUnitVisible == false)
                {
                    nudUnit.Value = 1;
                }
            }
            else
            {
                currBtnColor = Color.Red;
                nudUnit.Value = 0;
            }

            btnUnit.BackColor = currBtnColor;
            //toolTip1.SetToolTip(btnUnit, cmbUnit.SelectedValue.ToString() + " " + dtProducts.Rows[CmbSelectedIndex]["prix1"].ToString());
            cmbUnit.DroppedDown = false;
            btnUnit.Visible = true;
        }

        private void nudUnit_ValueChanged(object sender, EventArgs e)
        {
            nudUnit.Tag = Convert.ToInt32(nudUnit.Value);
            nudCurrValue = Convert.ToInt32(nudUnit.Value);
            if (cmbLastSelectedIndex == 0)
            {
                nudUnit.Value = 0;
            }
        }

        private void nudUnit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            nudUnit.Value = Convert.ToInt32(nudUnit.Tag);
        }

        private void nudUnit_Validating(object sender, CancelEventArgs e)
        {
            nudUnit.Value = Convert.ToInt32(nudUnit.Tag);
        }

        private void btnUnit_MouseLeave(object sender, EventArgs e)
        {
            //toolTip1.SetToolTip(this, cmbUnit.ValueMember.ToString());
            //toolTip1.Tag = cmbUnit.ValueMember.ToString();
            //toolTip1.ShowAlways = true;
            //toolTip1.Active = true;
            //toolTip1.ToolTipTitle = cmbUnit.SelectedValue.ToString();
            //toolTip1.SetToolTip(btnUnit, cmbUnit.SelectedValue.ToString());
            //MessageBox.Show("Leave");
            //toolTip1.Show(cmbUnit.SelectedValue.ToString() + " " + dtProducts.Rows[CmbSelectedIndex]["prix1"].ToString(), this.btnUnit);
        }


        private void uscUnit_MouseLeave(object sender, EventArgs e)
        {
            //toolTip1.SetToolTip(btnUnit, cmbUnit.SelectedValue.ToString() + " " + dtProducts.Rows[CmbSelectedIndex]["prix1"].ToString());
            //toolTip1.Show(cmbUnit.SelectedValue.ToString() + " " + dtProducts.Rows[CmbSelectedIndex]["prix1"].ToString(), this,this.Location );
            //toolTip1.Hide(this);
        }                                                                                                                     

        private void uscUnit_MouseHover(object sender, EventArgs e)
        {
            //toolTip1.Show(cmbUnit.SelectedValue.ToString() + " " + dtProducts.Rows[CmbSelectedIndex]["prix1"].ToString(), this, this.Location);
            //MessageBox.Show("Hover");
            //toolTip1.Hide(this);
        }

        private void btnUnit_MouseHover(object sender, EventArgs e)
        {
            //toolTip1.Show(cmbUnit.SelectedValue.ToString() + " " + dtProducts.Rows[CmbSelectedIndex]["prix1"].ToString(), this.btnUnit);
            try
            {
               toolTip1.Show(cmbUnit.SelectedValue.ToString() + " " + dtProducts.Rows[CmbSelectedIndex]["prix1"].ToString(), this.btnUnit);
            }
            catch
            {
                toolTip1.Show(cmbUnit.SelectedValue.ToString(), this.btnUnit);
            }
                
                
        }
    }
}
