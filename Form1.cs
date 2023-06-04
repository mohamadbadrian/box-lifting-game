using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace BoxLifting
{
    public partial class Form1 : Form
    {

        public DataTable dt = new DataTable();
        
        public int[] karegar = new int[2];
        public int[] stopzone = new int[2];
        bool chkpress = true;
        int level = 1;
        bool fdraw = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            boxM1.Visible = false;
            boxM2.Visible = false;
            boxM3.Visible = false;
            boxM4.Visible = false;
            boxM5.Visible = false;
            boxM6.Visible = false;
            boxM7.Visible = false;
            boxM8.Visible = false;
            boxM9.Visible = false;
            boxM10.Visible = false;
            boxM11.Visible = false;
            setlevel(Convert.ToString(level));
            timer();
            

        }
        public void timer()
        {
            
            timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 10; // 10 mili second
            timer2.Start();
        }
       
        public void moving(int id,string side)//id =1 yani kargar id=2 yani box-----string = L left...R right...D down....U up
        {

            int row = karegar[0], col = karegar[1];
           
            if (id == 1)// code kargar
            {
                switch (side)
                {
                    case "L": { try { if (dt.Rows[row][col - 1].ToString() == "2") { moving(2, "L"); } if (dt.Rows[row][col - 1].ToString() == "4") { moving(3, "L"); } if (dt.Rows[row][col - 1].ToString() == "0") { dt.Rows[row][col] = 0; dt.Rows[row][col-1] = 1; col -= 1; } } catch { } } break;
                    case "R": { try { if (dt.Rows[row][col + 1].ToString() == "2") { moving(2, "R"); } if (dt.Rows[row][col + 1].ToString() == "4") { moving(3, "R"); } if (dt.Rows[row][col + 1].ToString() == "0") { dt.Rows[row][col] = 0; dt.Rows[row][col+1] = 1; col += 1; } } catch { } } break;
                    case "D": { try { if (dt.Rows[row + 1][col].ToString() == "2") { moving(2, "D"); } if (dt.Rows[row + 1][col].ToString() == "4") { moving(3, "D"); } if (dt.Rows[row + 1][col].ToString() == "0") { dt.Rows[row][col] = 0; dt.Rows[row + 1][col] = 1; row += 1; } } catch { } } break;
                    case "U": { try { if (dt.Rows[row - 1][col].ToString() == "2") { moving(2, "U"); } if (dt.Rows[row - 1][col].ToString() == "4") { moving(3, "U"); } if (dt.Rows[row - 1][col].ToString() == "0") { dt.Rows[row][col] = 0; dt.Rows[row - 1][col] = 1; row -= 1; } } catch { } } break;
                }
                karegar[0] = row;
                karegar[1] = col;
            }
            else if (id == 2)  //code jabehaye motaharek
            {
                switch (side)
                {
                    case "L": { try { if ((dt.Rows[row][col - 1].ToString() == "2") && (dt.Rows[row][col - 2].ToString() == "0")) { dt.Rows[row][col - 1] = 0; dt.Rows[row][col - 2] = 2; col -= 1; } } catch { } } break;
                    case "R": { try { if ((dt.Rows[row][col + 1].ToString() == "2") && (dt.Rows[row][col + 2].ToString() == "0")) { dt.Rows[row][col + 1] = 0; dt.Rows[row][col + 2] = 2; col += 1; } } catch { } } break;
                    case "D": { try { if ((dt.Rows[row + 1][col].ToString() == "2") && (dt.Rows[row + 2][col].ToString() == "0")) { dt.Rows[row + 1][col] = 0; dt.Rows[row + 2][col] = 2; row += 1; } } catch { } } break;
                    case "U": { try { if ((dt.Rows[row - 1][col].ToString() == "2") && (dt.Rows[row - 2][col].ToString() == "0")) { dt.Rows[row - 1][col] = 0; dt.Rows[row - 2][col] = 2; row -= 1; } } catch { } } break;
                }
            }
            else if (id == 3)  //code jabeye asli
            {
                
                switch (side)
                {
                    case "L": { try { if ((dt.Rows[row][col - 1].ToString() == "4") && (dt.Rows[row][col - 2].ToString() == "0")) { dt.Rows[row][col - 1] = 0; dt.Rows[row][col - 2] = 4; col -= 1; } } catch { } } break;
                    case "R": { try { if ((dt.Rows[row][col + 1].ToString() == "4") && (dt.Rows[row][col + 2].ToString() == "0")) { dt.Rows[row][col + 1] = 0; dt.Rows[row][col + 2] = 4; col += 1; } } catch { } } break;
                    case "D": { try { if ((dt.Rows[row + 1][col].ToString() == "4") && (dt.Rows[row + 2][col].ToString() == "0")) { dt.Rows[row + 1][col] = 0; dt.Rows[row + 2][col] = 4; row += 1; } } catch { } } break;
                    case "U": { try { if ((dt.Rows[row - 1][col].ToString() == "4") && (dt.Rows[row - 2][col].ToString() == "0")) { dt.Rows[row - 1][col] = 0; dt.Rows[row - 2][col] = 4; row -= 1; } } catch { } } break;
                }

            }
                
            
        }
        public void drawback()
        {
            int con1 = 0;
            int con2 = 0;
            int x = 0;
            int y = 0;
            
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                     x = 0;
                     y = 0;
                    switch (i)
                    {
                        case 0: { y = 9; }
                            break;
                        case 1: { y = 50; }
                            break;
                        case 2: { y = 92; }
                            break;
                        case 3: { y = 134; }
                            break;
                        case 4: { y = 177; }
                            break;
                        case 5: { y = 219; }
                            break;

                    }
                    switch (j)
                    {
                        case 0: { x = 7; }
                            break;
                        case 1: { x = 49; }
                            break;
                        case 2: { x = 91; }
                            break;
                        case 3: { x = 134; }
                            break;
                        case 4: { x = 174; }
                            break;
                        case 5: { x = 217; }
                            break;
                     
                    }
                   

                    if (dt.Rows[i][j].ToString() == "1")//kargar
                    {
                        karegar[0] = i;
                        karegar[1] = j;
                        pbworker.Location =new Point(x,y);
                        
                    }

                    if (dt.Rows[i][j].ToString() == "2")//jabehaye motaharek
                    {
                        con1++;
                        boxsabet(con1, x, y);
                        
                    }
                    if (dt.Rows[i][j].ToString() == "3")//jabehaye sabet
                    {
                        con2++;
                        
                        
                    }
                    if (dt.Rows[i][j].ToString() == "4")//jabeye asli
                    {
                        boxAsl.Location = new Point(x, y);
                    }
                    if (dt.Rows[i][j].ToString() == "5")//dropzone
                    {

                        stopzone[0] = i;
                        stopzone[1] = j;
                        dt.Rows[i][j] = 0;
                    }
                    
                }
            }
            
        }
        
        public void boxsabet(int tedad,int x, int y)
        {
                
                switch (tedad)
                {
                    case 1: { boxM1.Location = new Point(x, y); boxM1.Visible = true;  }
                        break;
                    case 2: { boxM2.Location = new Point(x, y); boxM2.Visible = true; }
                        break;
                    case 3: { boxM3.Location = new Point(x, y); boxM3.Visible = true; }
                        break;
                    case 4: { boxM4.Location = new Point(x, y); boxM4.Visible = true; }
                        break;
                    case 5: { boxM5.Location = new Point(x, y); boxM5.Visible = true; }
                        break;
                    case 6: { boxM6.Location = new Point(x, y); boxM6.Visible = true; }
                        break;
                    case 7: { boxM7.Location = new Point(x, y); boxM7.Visible = true; }
                        break;
                    case 8: { boxM8.Location = new Point(x, y); boxM8.Visible = true; }
                        break;
                    case 9: { boxM9.Location = new Point(x, y); boxM9.Visible = true; }
                        break;
                    case 10: { boxM10.Location = new Point(x, y); boxM10.Visible = true; }
                        break;
                    case 11: { boxM11.Location = new Point(x, y); boxM11.Visible = true; }
                        break;
                   
                }
            
           
            
        }

        public void setlevel(string level)
        {
            DataSet ds = new DataSet();
            if(System.IO.File.Exists(Application.StartupPath + @"\XML\Level-" + level.ToString() + ".xml"))
            {
                if (System.IO.File.Exists(Application.StartupPath + @"\Images\Level\level-" + level.ToString() + ".jpg"))
                {
                    ds.ReadXml(Application.StartupPath + @"\XML\Level-" + level.ToString() + ".xml");
                    dt = ds.Tables[0];
                    panel1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Images\Level\level-" + level.ToString() + ".jpg");
                    
                }
                else
                {
                    MessageBox.Show("Congratulation!!! You Finish the Game...!");
                  
                }
            }
           
        }
        public void checkvictory()
            {
                int row = 0;
                int col = 0;
                row = stopzone[0];
                col = stopzone[1];
                if (dt.Rows[row][ col].ToString() == "4")
                {

                    MessageBox.Show("VicTory!!!");
                    level++;
                    boxM1.Visible = false;
                    boxM2.Visible = false;
                    boxM3.Visible = false;
                    boxM4.Visible = false;
                    boxM5.Visible = false;
                    boxM6.Visible = false;
                    boxM7.Visible = false;
                    boxM8.Visible = false;
                    boxM9.Visible = false;
                    boxM10.Visible = false;
                    boxM11.Visible = false;
                    setlevel(Convert.ToString(level));
                    drawback();
                }
            }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (chkpress == true)
            {
                chkpress = false;
                if (e.KeyValue.ToString() == "37")//left
                {
                    moving(1, "L");
                    pbworker.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\worker-left-far.png");
                    drawback();
                    checkvictory();
                }
                if (e.KeyValue.ToString() == "38")//up
                {
                    moving(1, "U");
                    pbworker.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\worker-top-far.png");
                    drawback();
                    checkvictory();
                }
                if (e.KeyValue.ToString() == "39")//right
                {
                    moving(1, "R");
                    pbworker.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\worker-right-far.png");
                    drawback();
                    checkvictory();
                }
                if (e.KeyValue.ToString() == "40")//down
                {
                    moving(1, "D");
                    pbworker.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Images\\worker-down-far.png");
                    drawback();
                    checkvictory();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            chkpress = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (fdraw == false)
            {
                timer2.Enabled = false;
                drawback();
                fdraw = true;
            }
        }

        

        

       
    }
}
