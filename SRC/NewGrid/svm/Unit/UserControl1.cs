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
            //cmbUnit.DataSource = dtProducts;//bsProduct;
            //cmbUnit.DisplayMember = "nom1";
            //cmbUnit.ValueMember = "nom1";
            //cmbUnit.DataSource = dtProducts;
        }


        public uscUnit(DataTable dt) :this()
        {
            ProductsSource = dt.Copy();
            cmbUnit.DisplayMember = "nom1";
            cmbUnit.ValueMember = "nom1";
            cmbUnit.DataSource = dtProducts;
        }


        private DataTable dtProducts=new DataTable();
        private String s = String.Empty;
        private Dictionary<string, int> dicProducts = new Dictionary<string, int>();

        
        private BindingSource bsProduct = new BindingSource();

        public BindingSource BindingProducts
        {
            set
            {
                bsProduct = value;
                //cmbUnit.DisplayMember = "nom1";
                cmbUnit.DataSource = value;
                cmbUnit.DisplayMember = "nom1";
                cmbUnit.ValueMember = "nom1";
                
                //bsProduct;
                
                bsProduct.ResetBindings(false);
                //bsProduct.ResumeBinding();

            }
            get
            {
                return bsProduct;
            }
        }

        private void MakeProductsDic()
        {
            if (!dicProducts.ContainsKey("Not use"))
            {
                dicProducts.Add("Not use", 0);
            }

            for (int i = 0; i < dtProducts.Rows.Count; i++)
            {
                if (!dicProducts.ContainsKey(dtProducts.Rows[i][0].ToString().Trim()))
                {
                    dicProducts.Add(dtProducts.Rows[i][0].ToString().Trim(),i+1);
                }
            }
        }

        public int cmbLastSelectedIndex
        {
            get;
            set;
        }

        public String NumberOfList
        {
            get
            {
                return gbxUnit.Text; 
            }
            set
            {
                gbxUnit.Text = value;
            }
        }

        private int nudCurrValue
        {
            get;
            set;
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
        
        private void btnUnit_Set()
        {

        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGridUnit();
        }

        private void uscUnit_Load(object sender, EventArgs e)
        {
            //cmbUnit.DisplayMember = "nom1";
            //cmbUnit.ValueMember = "nom1";
            //cmbUnit.DataSource = dtProducts;
            //nudUnit.Value = maxValueOfUnit;
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
            cmbLastSelectedIndex = cmbUnit.SelectedIndex;
            btnUnit.Text = cmbUnit.Text.ToString();
            Color currBtnColor = btnUnit.BackColor;
            
            if (cmbUnit.SelectedIndex > 0)
            {
                currBtnColor = Color.LawnGreen;
            }
            else
            {
                currBtnColor = Color.Red;
                nudUnit.Value = 0;
            }

            btnUnit.BackColor = currBtnColor;
            cmbUnit.DroppedDown = false;
            btnUnit.Visible = true;
        }

        private void nudUnit_ValueChanged(object sender, EventArgs e)
        {
            nudUnit.Tag = Convert.ToInt32(nudUnit.Value);
            nudCurrValue  = Convert.ToInt32(nudUnit.Value);
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
        
    }
}
