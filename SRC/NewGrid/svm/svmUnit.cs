using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Unit;
using System.Data;

namespace svm
{
    public class svmUnit
    {
        private static List<GroupBox> arrGroupBoxes = new List<GroupBox>();
        private static List<string> arrCurrModele = new List<string>();
        private static string[] sarrNamesOldBar = new String[] { "Left Side","Right Side","Tray","Tray"};
        private static string[] sarrNamesNewBar = new String[] { "Top Shelf", "Bottom Shelf", "Balcony 1","Balcony 2", "Tray" };
        private static List<uscUnit> arrGridUnits= new List<uscUnit>();
        
        public static GroupBox grbMain = new GroupBox();
        public static GroupBox grbMainForView = new GroupBox();
        private static int iModeleIndex = -1;

        public static List<GroupBox> Groups
        {
            get
            {
                return arrGroupBoxes;
            }
        }

        public static int CountOfProductsOldBar
        {
            set;
            get;
        }
        
        public static int CountOfProductsNewBar
        {
            set;
            get;
        }

        public static int MaxCountOfProducts
        {
            set;
            get;
        }

        public static DataTable ProductSource
        {
            set
            {
                dtProducts = value.Copy();
                if (arrGridUnits.Count > 0)
                {
                    for (int i = 0; i < arrGridUnits.Count; i++)
                    {
                        arrGridUnits[i].ProductsSource = dtProducts;
                    }
                }
            }
            get
            {
                return dtProducts;
            }
        }

        private static DataTable dtProducts
        {
            set;
            get;
        }

        
        public static DataTable dtModele
        {
            set;
            protected get;
        }

        public static int iCurrModeleIndex
        {
            set
            {
                if (value >= 0)
                {
                    iModeleIndex = value;
                    
                }
                else
                {
                    iModeleIndex = -1;
                }
                RefreshUnit();
            }

            protected get
            {
                return iModeleIndex;
            }
        }

        public static string Modele
        {
            get
            {
                string sProduct = String.Empty, sQvantyty = String.Empty;

                for (int i = 0; i < arrGridUnits.Count; i++)
                {
                    sProduct += ((uscUnit)arrGridUnits[i]).CmbSelectedValue + "|";
                    sQvantyty += ((uscUnit)arrGridUnits[i]).maxValueOfUnit + "|";
                }
                return (sProduct + sQvantyty.Remove(sQvantyty.Length - 1)).ToString();
            }
        }

        public static void SetSvm()
        {
            //SetGridUnit();
            FillArrayGridUnit();
            //SetGroupBox();
            //SetGroupBoxNew();
        }

        public static void RefreshUnit()
        {
            //MessageBox.Show(iCurrModeleIndex.ToString());
            for (int i = 1; i <=MaxCountOfProducts; i++)
            {
                if (iCurrModeleIndex == -1 || dtModele == null || dtModele.Rows.Count==0 )
                {
                    arrGridUnits[i - 1].CmbSelectedValue = "";
                    arrGridUnits[i - 1].maxValueOfUnit = 0;
                }
                else
                {
                    //MessageBox.Show(dtModele.Rows[iCurrModeleIndex][i].ToString());
                    arrGridUnits[i - 1].CmbSelectedValue = dtModele.Rows[iCurrModeleIndex][i].ToString();
                    arrGridUnits[i - 1].maxValueOfUnit = Convert.ToInt32(dtModele.Rows[iCurrModeleIndex]["q"+i.ToString()]);
                }
            }
        }

        private static void SetGroupBoxNew()
        {
            arrGroupBoxes.Clear();
            GroupBox grbShelfs = null;
            int j = 0;
            for (int i = 0, iHeight = 15; i < 2; i++)
            {
                grbShelfs = new GroupBox();
                grbShelfs.Location = new Point(10, iHeight);
                grbShelfs.Text = sarrNamesNewBar[i];
                grbShelfs.Font = new Font(grbShelfs.Font, FontStyle.Bold);
                for (int ii = 1; ii <= 12; ii++)
                {
                    grbShelfs.Controls.Add((uscUnit)arrGridUnits[j++]);
                }

                //grbShelfs.Size = new Size(uscUnit.Dimention.Width * 4 + 10, uscUnit.Dimention.Height * 2 + 20);
                grbShelfs.Size = new Size(arrGridUnits[0].Width * 4 + 10, arrGridUnits[0].Height * 3 + 20);
                iHeight = grbShelfs.Height + grbShelfs.Location.Y + 1;
                arrGroupBoxes.Add(grbShelfs);
            }

            //Balcony
            int iWidth = grbShelfs.Location.X + grbShelfs.Width + 1;
            grbShelfs = new GroupBox();

            grbShelfs.Location = new Point(iWidth, 15);
            grbShelfs.Text = sarrNamesNewBar[2];
            grbShelfs.Font = new Font(grbShelfs.Font, FontStyle.Bold);
            j = 24;
            for (int ii = 1; ii <= 6; ii++)
            {
                grbShelfs.Controls.Add((uscUnit)arrGridUnits[j++]);
            }
            grbShelfs.Size = new Size(uscUnit.Dimention.Width + 10, uscUnit.Dimention.Height * 6 + 20);
            //grbShelfs.Size = new Size(uscUnit. + 10, uscUnit.Dimention.Height * 8 + 20);
            iWidth = grbShelfs.Width + grbShelfs.Location.X + 1;
            arrGroupBoxes.Add(grbShelfs);

            grbShelfs = new GroupBox();

            grbShelfs.Location = new Point(iWidth, 15);
            grbShelfs.Text = sarrNamesNewBar[3];
            grbShelfs.Font = new Font(grbShelfs.Font, FontStyle.Bold);
            for (int ii = 1; ii <= 6; ii++)
            {
                grbShelfs.Controls.Add((uscUnit)arrGridUnits[j++]);
            }
            grbShelfs.Size = new Size(uscUnit.Dimention.Width + 10, uscUnit.Dimention.Height * 6 + 20);
            //grbShelfs.Size = new Size(uscUnit. + 10, uscUnit.Dimention.Height * 8 + 20);
            iWidth = grbShelfs.Width + grbShelfs.Location.X + 1;
            arrGroupBoxes.Add(grbShelfs);



            //Tray

            grbShelfs = new GroupBox();
            grbShelfs.Location = new Point(iWidth, 15);
            grbShelfs.Text = sarrNamesNewBar[4];
            grbShelfs.Font = new Font(grbShelfs.Font, FontStyle.Bold);
            j = 36;
            for (int ii = 1; ii <= 8; ii++)
            {
                grbShelfs.Controls.Add((uscUnit)arrGridUnits[j++]);
            }
            grbShelfs.Size = new Size(uscUnit.Dimention.Width * 4 + 10, uscUnit.Dimention.Height * 2 + 20);
            iWidth = grbShelfs.Width + grbShelfs.Location.X + 1;
            arrGroupBoxes.Add(grbShelfs);
        }

        private static void SetGroupBoxNew(int value)
        {
            arrGroupBoxes.Clear();
            GroupBox grbShelfs=null;
            int j = 0;
            for (int i = 0,iHeight=15; i < 3; i++)
            {
                grbShelfs = new GroupBox();
                grbShelfs.Location = new Point(10, iHeight);
                grbShelfs.Text = sarrNamesNewBar[i];
                grbShelfs.Font = new Font(grbShelfs.Font, FontStyle.Bold);
                for (int ii = 1; ii <= 8; ii++)
                {
                    grbShelfs.Controls.Add((uscUnit)arrGridUnits[j++]);
                }
                
                //grbShelfs.Size = new Size(uscUnit.Dimention.Width * 4 + 10, uscUnit.Dimention.Height * 2 + 20);
                grbShelfs.Size = new Size(arrGridUnits[0].Width * 4 + 10, arrGridUnits[0].Height * 2 + 20);
                iHeight = grbShelfs.Height + grbShelfs.Location.Y + 1;
                arrGroupBoxes.Add(grbShelfs);
            }
            //Balcony
            int iWidth = grbShelfs.Location.X + grbShelfs.Width + 1;
            grbShelfs = new GroupBox();
            
            grbShelfs.Location = new Point(iWidth,15);
            grbShelfs.Text = sarrNamesNewBar[3];
            grbShelfs.Font = new Font(grbShelfs.Font, FontStyle.Bold);
            for (int ii = 1; ii <= 8; ii++)
            {
                grbShelfs.Controls.Add((uscUnit)arrGridUnits[j++]);
            }
            grbShelfs.Size = new Size(uscUnit.Dimention.Width + 10, uscUnit.Dimention.Height * 8 + 20);
            //grbShelfs.Size = new Size(uscUnit. + 10, uscUnit.Dimention.Height * 8 + 20);
            iWidth = grbShelfs.Width + grbShelfs.Location.X + 1;
            arrGroupBoxes.Add(grbShelfs);
            //Tray
            
            grbShelfs = new GroupBox();
            grbShelfs.Location = new Point(iWidth, 15);
            grbShelfs.Text = sarrNamesNewBar[4];
            grbShelfs.Font = new Font(grbShelfs.Font, FontStyle.Bold);
            for (int ii = 1; ii <= 8; ii++)
            {
                grbShelfs.Controls.Add((uscUnit)arrGridUnits[j++]);
            }
            grbShelfs.Size = new Size(uscUnit.Dimention.Width * 4 + 10, uscUnit.Dimention.Height * 2 + 20);
            iWidth = grbShelfs.Width + grbShelfs.Location.X + 1;
            arrGroupBoxes.Add(grbShelfs);

        }

        private static void SetGroupBox_1()
        {
            arrGroupBoxes.Clear();
            int iColumnCount = CountOfProductsOldBar / 4;
            for (int i = 0, j = 0, grbWidth = 10; i < iColumnCount; i++)
            {
                GroupBox grbShelfs = new GroupBox();
                grbShelfs.Location = new Point(grbWidth, 15);
                //grbShelfs.Text = sarrNamesOldBar[i];
                grbShelfs.Font = new Font(grbShelfs.Font, FontStyle.Bold);
                for (int ii = 1; ii <= 4; ii++)
                {
                    
                    grbShelfs.Controls.Add((uscUnit)arrGridUnits[j++]);
                }
                grbShelfs.Size = new Size(uscUnit.Dimention.Width + 10, uscUnit.Dimention.Height * 4 + 20);

                grbWidth = grbShelfs.Width + grbShelfs.Location.X;
                arrGroupBoxes.Add(grbShelfs);
            }

        }

        private static void SetGroupBox()
        {
            arrGroupBoxes.Clear();
            int iColumnCount = CountOfProductsOldBar / 4;
            for (int i = 0, j = 0, grbWidth = 10; i < iColumnCount; i++)
            {
                GroupBox grbShelfs = new GroupBox();
                grbShelfs.Location = new Point(grbWidth, 15);
                grbShelfs.Text = sarrNamesOldBar[i];
                grbShelfs.Font = new Font(grbShelfs.Font, FontStyle.Bold);
                for (int ii = 1; ii <= 4; ii++)
                {
                    grbShelfs.Controls.Add((uscUnit)arrGridUnits[j++]);
                }
                grbShelfs.Size = new Size(uscUnit.Dimention.Width + 10, uscUnit.Dimention.Height * 4 + 20);
                
                grbWidth = grbShelfs.Width + grbShelfs.Location.X;
                arrGroupBoxes.Add(grbShelfs);
            }
            
        }

        private static void FillArrayGridUnit()
        {
            for (int i=1;i<=MaxCountOfProducts;i++)
            {
                uscUnit userUnit = new uscUnit(dtProducts);
                userUnit.Name = "usrUnit" + i.ToString();
                userUnit.Font = new Font(userUnit.Font, FontStyle.Regular);
                userUnit.ProductsSource = dtProducts;
                userUnit.CmbSelectedValue = "";//dtModele.Rows[iCurrModeleIndex][i].ToString();
                userUnit.maxValueOfUnit = 0;//Convert.ToInt32(dtModele.Rows[iCurrModeleIndex][i + 12]);
                userUnit.NumberOfList = i.ToString();
                arrGridUnits.Add(userUnit);
            }
        }

        public static void ShowOldGridForView()
        {
            //SetGroupBox();
            int x = 5, y = 15;
            for (int i = 0; i < MaxCountOfProducts; i++)
            {
                arrGridUnits[i].nudUnitVisible = true;
            }

            //int vOfs = uscUnit.Dimention.Height;
            int vOfs = arrGridUnits[0].Height;
            for (int i = 0, j = 0; i < CountOfProductsOldBar; i++)
            {
                //vOfs = arrGridUnits[i].Height;
                arrGridUnits[i].Location = new Point(x, y + vOfs * j++);

                if ((i + 1) % 4 == 0)
                {
                    //y = 15;
                    //x = 5;
                    j = 0;
                }

            }
            SetGroupBox();
            grbMainForView.Controls.Clear();
            for (int i = 0; i < arrGroupBoxes.Count; i++)
            {
                grbMainForView.Controls.Add(arrGroupBoxes[i]);
                grbMainForView.Height = arrGroupBoxes[i].Height + 10;
            }

            grbMainForView.AutoSize = true;
            //grbMain.Text = "SVM modele";
            //grbMain.Refresh();

        }


        public static void ShowOldGrid()
        {
            //SetGroupBox();
            int x = 5, y = 15;
            for (int i = 0; i < MaxCountOfProducts; i++)
            {
                arrGridUnits[i].nudUnitVisible = true;
            }
            
            //int vOfs = uscUnit.Dimention.Height;
            int vOfs = arrGridUnits[0].Height;
            for (int i = 0, j = 0; i < CountOfProductsOldBar; i++)
            {
                //vOfs = arrGridUnits[i].Height;
                arrGridUnits[i].Location = new Point(x, y + vOfs * j++);
                
                if ((i+1) % 4 == 0)
                {
                    //y = 15;
                    //x = 5;
                    j = 0;
                }

            }
            SetGroupBox();
            grbMain.Controls.Clear();
            for (int i = 0; i < arrGroupBoxes.Count; i++)
            {
                grbMain.Controls.Add(arrGroupBoxes[i]);
                grbMainForView.Height = arrGroupBoxes[i].Height + 10;
            }

            grbMain.AutoSize = true;
            //grbMain.Text = "SVM modele";
            //grbMain.Refresh();
            
        }

        public static void ShowNewGrid()
        {
            int x = 5, y = 15;

            for (int i = 0; i < MaxCountOfProducts; i++)
            {
                arrGridUnits[i].nudUnitVisible = false;
            }
            int vOfs = uscUnit.Dimention.Height, hOfs = uscUnit.Dimention.Width;
            //top shelf
            for (int i = 0, j = 0, ofs = 8; i < 8; i += 2)
            {
                arrGridUnits[i].Location = new Point(x + hOfs * j, y + vOfs);
                arrGridUnits[i + 1].Location = new Point(x + hOfs * j, y);
                arrGridUnits[i + ofs--].Location = new Point(x + hOfs * j++, y + vOfs * 2);
             }
            
            //bottom shelf
            for (int i = 12, j = 0, ofs = 8; i < 20; i += 2)
            {
                arrGridUnits[i].Location = new Point(x + hOfs * j, y + vOfs);
                arrGridUnits[i + 1].Location = new Point(x + hOfs * j, y);
                arrGridUnits[i + ofs--].Location = new Point(x + hOfs * j++, y + vOfs * 2);
            }
            //balcony
            for (int i = 24, j = 0; i < 30; i++)
            {
                arrGridUnits[i].Location = new Point(x, y + vOfs * j++);

            }

            for (int i = 30, j = 0; i < 36; i++)
            {
                arrGridUnits[i].Location = new Point(x, y + vOfs * j++);

            }
            
            //Tray
            x = 5;
            y = 15;
            for (int i = 36, j = 0; i < MaxCountOfProducts; i++)
            {
                arrGridUnits[i].Location = new Point(x + hOfs * j++, y);
                //arrGridUnits[i + 1].Location = new Point(x + hOfs * j++, y);
                if (j % 4 == 0)
                {
                    j = 0;
                    y += vOfs;
                }
            }


            SetGroupBoxNew();
            grbMain.Controls.Clear();
            for (int i = 0; i < arrGroupBoxes.Count; i++)
            {
                grbMain.Controls.Add(arrGroupBoxes[i]);
            }

            grbMain.AutoSize = true;


        }


        public static void ShowNewGrid(int value)
        {
            int x = 5, y = 15;
            
            for (int i = 0; i < MaxCountOfProducts; i++)
            {
                arrGridUnits[i].nudUnitVisible = false;
            }
            int vOfs = uscUnit.Dimention.Height, hOfs = uscUnit.Dimention.Width;
            for (int i = 0, j = 0; i < 24; i+=2)
            {
                arrGridUnits[i].Location = new Point(x + hOfs * j, y + vOfs);
                arrGridUnits[i + 1].Location = new Point(x + hOfs *j++, y);
                if ((i+2) % 8 == 0)
                {
                    //y = 15;
                    //x = 5;
                    j = 0;
                }

            }
            //balcony
            x = 5;
            y = 15;
            for (int i = 24, j = 0; i < 30; i++)
            {
                arrGridUnits[i].Location = new Point(x, y + vOfs * j++);
            }
            //Tray
            x = 5;
            y = 15;
            for (int i = 32, j = 0; i < 40; i += 2)
            {
                arrGridUnits[i].Location = new Point(x + hOfs * j, y + vOfs);
                arrGridUnits[i + 1].Location = new Point(x + hOfs * j++, y);
            }

            SetGroupBoxNew();
            grbMain.Controls.Clear();
            for (int i = 0; i < arrGroupBoxes.Count; i++)
            {
                grbMain.Controls.Add(arrGroupBoxes[i]);
            }
            
            grbMain.AutoSize = true;
            //grbMain.Refresh();
        }

        private static void SetGridUnit()
        {
            int x = 5, y = 15;
            int vOfs = 0;

            for (int i = 1, j = 0; i <=CountOfProductsOldBar ; i++)
            {
                uscUnit userUnit = new uscUnit(dtProducts);
                vOfs = userUnit.Height;
                userUnit.Name = "usrUnit" + i.ToString();
                userUnit.Location = new Point(x, y + vOfs * j++);
                userUnit.ProductsSource = dtProducts;
                userUnit.CmbSelectedValue = "";//dtModele.Rows[iCurrModeleIndex][i].ToString();
                userUnit.maxValueOfUnit = 0;//Convert.ToInt32(dtModele.Rows[iCurrModeleIndex][i + 12]);
                userUnit.NumberOfList = i.ToString();
                arrGridUnits.Add(userUnit);
                if (i % 4 == 0)
                {
                    y = 15;
                    x = 5;
                    j = 0;
                }
            }
        }

    }
}
