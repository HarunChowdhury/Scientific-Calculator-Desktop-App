using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpendedScientificCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //--------------Initial Declaration ------------------------------------------------------------
      public double pday,pmonth,pyear,bday,bmonth,byear,D=0,M=0,Y=0;
      public  double firstnum;
      public  double secondnum;
      public  double Result;
      public double pi =Convert.ToDouble( Math.PI.ToString());
      public  char operation,op;
      public string strInput, storeString;
      public double e1, e2;
      public double sign;
      public long s1, num1, num2, Remainder, Dec_num, Base_value;
      public string s,d1,o1,h1,b1,clc;
      public char[] arr1;
      private void button2_Click(object sender, EventArgs e) //button for 1
        {
          
              if(lblDisplay.Text=="0")
              {
                  lblDisplay.Text ="1"; 
                
              }

              else
              {
                  lblDisplay.Text=Convert.ToString(lblDisplay.Text)+"1";
              }
        }

      private void button1_Click(object sender, EventArgs e) //button for 2
        {
           
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "2";
              
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "2";
            }
        }

      private void button3_Click(object sender, EventArgs e) //button for 3
        {
           
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "3";
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "3";
            }
        }

      private void button4_Click(object sender, EventArgs e) //button for 4
        {
         
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "4";
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "4";
            }
        }

      private void button5_Click(object sender, EventArgs e) //button for 5
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "5";
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "5";
            }
        }

      private void button6_Click(object sender, EventArgs e) //button for 6
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "6";
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "6";
            }
        }

      private void button7_Click(object sender, EventArgs e) //button for 7
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "7";
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "7";
            }
        }

      private void button8_Click(object sender, EventArgs e)  //button for 8
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "8";
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "8";
            }
        }

      private void button9_Click(object sender, EventArgs e) //button for 9
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "9";
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "9";
            }
        }

      private void button10_Click(object sender, EventArgs e) //button for 0
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "0";
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e) // clear Button
        {
            lblDisplay.Text = "";
            lblDisplay.Text = "0";
            clc = lblDisplay.Text;
        
        }

        private void button12_Click(object sender, EventArgs e) // Divission
        {
          
            firstnum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = '/';
        }

        private void button13_Click(object sender, EventArgs e) // Subtraction
        {
                     
            if (lblDisplay.Text== "0")
            {
               lblDisplay.Text = "-";             
            }

            else
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = "0";
                operation = '-';
            }
        }

        private void button14_Click(object sender, EventArgs e) // Multiplication
        {
            firstnum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = 'x';
        }

        private void button15_Click(object sender, EventArgs e) // Addition
        {
            firstnum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = '+';
        }

        //--------------------------------------------------------------------------
        //--------------------------- Equal (=) Button Operation -----------------------------------------------
        private void button16_Click(object sender, EventArgs e)  // = button
        {
            
                secondnum = Convert.ToDouble(lblDisplay.Text);  

                        switch (operation)
                        {
                            case '+':
                                Result = firstnum + secondnum;
                                lblDisplay.Text = System.Convert.ToString(Result);
                                break;
                            case '-':
                                Result = firstnum -secondnum;
                                lblDisplay.Text = System.Convert.ToString(Result);
                                break;

                            case 'x':
                                Result = firstnum * secondnum;
                                lblDisplay.Text = System.Convert.ToString(Result);
                                break;
                            case '/':
                                Result = firstnum / secondnum;
                                lblDisplay.Text = System.Convert.ToString(Result);
                                break;
                            case 'm':
                                Result = firstnum % secondnum;
                                lblDisplay.Text = System.Convert.ToString(Result);
                                break;
                            case '^':
                                lblDisplay.Text = System.Convert.ToString(Math.Pow(firstnum, secondnum));
                                break;
                        
                            

                            default :
                                lblDisplay.Text = "Nothing Done, Now Do 'Clear'";
                                break;

                      }   
           
       }

        private void button35_Click(object sender, EventArgs e) // factorial Button
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                double factorial = 1;
                if (firstnum == 1)
                {
                    lblDisplay.Text = Convert.ToString(factorial);
                }
                else
                {

                    for (int i = 1; i <= firstnum; i++)
                    {
                        factorial = factorial * i;
                    }

                    lblDisplay.Text = Convert.ToString(factorial);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button31_Click(object sender, EventArgs e) //Multiplicaton button
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                double square = firstnum * firstnum;
                lblDisplay.Text = Convert.ToString(square);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button34_Click(object sender, EventArgs e) //Pi*x button
        {
           try
           {                  
                firstnum = Convert.ToDouble(lblDisplay.Text);
                double pi = firstnum*3.1416;
                lblDisplay.Text = System.Convert.ToString(pi);

                if (lblDisplay.Text=="0") 
                    
                    lblDisplay.Text = "3.1416";        
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button30_Click(object sender, EventArgs e) // sqrt button
        {
            try
            {

            firstnum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = Convert.ToString(Math.Sqrt(firstnum));

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button33_Click(object sender, EventArgs e) // inverse button
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = Convert.ToString(1 / firstnum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button32_Click(object sender, EventArgs e) // log button
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = System.Convert.ToString(Math.Log10(firstnum));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button28_Click(object sender, EventArgs e)  
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = System.Convert.ToString(Math.Log(firstnum));
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                secondnum = (firstnum * pi) / 180;
                lblDisplay.Text = Convert.ToString(Math.Sin(secondnum));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            
       
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                e1=Math.Exp(firstnum);
                e2 =1/e1;
                sign=(e1-e2)/2;       
                lblDisplay.Text=Convert.ToString(sign);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button21_Click(object sender, EventArgs e)
        {

            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                secondnum = (firstnum * pi) / 180;
                lblDisplay.Text = Convert.ToString(Math.Cos(secondnum));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                e1 = Math.Exp(firstnum);
                e2 = 1 / e1;
                sign = (e1 + e2) / 2;
                lblDisplay.Text = Convert.ToString(sign);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button23_Click(object sender, EventArgs e)
        {

            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                secondnum = (firstnum * pi) / 180;
                lblDisplay.Text = Convert.ToString(Math.Tan(secondnum));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
         
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                e1 = Math.Exp(firstnum);
                e2 = 1 / e1;
                sign = (e1 - e2) / 2;
                secondnum = (e1 + e2) / 2;
                lblDisplay.Text = Convert.ToString(sign/secondnum);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                strInput=Convert.ToString(Math.Asin(firstnum));
                secondnum = Convert.ToDouble(strInput);
                lblDisplay.Text = Convert.ToString((secondnum*180)/pi);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                strInput = Convert.ToString(Math.Acos(firstnum));
                secondnum = Convert.ToDouble(strInput);
                lblDisplay.Text = Convert.ToString((secondnum * 180) / pi);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                strInput = Convert.ToString(Math.Atan(firstnum));
                secondnum = Convert.ToDouble(strInput);
                lblDisplay.Text = Convert.ToString((secondnum * 180) / pi);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        private void button43_Click_1(object sender, EventArgs e)
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
             
                lblDisplay.Text = "0";
                operation = '^';
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void button25_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation='m';
         
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = System.Convert.ToString(Math.Exp(firstnum));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button29_Click(object sender, EventArgs e)   //decimal indicator
        {


            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text ="0"+ ".";
            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + ".";
            } 
        }

        private void button42_Click(object sender, EventArgs e)
        {

            strInput = lblDisplay.Text;
            int l = strInput.Length;
            for (int i = 0; i < l - 1; i++)
            {
                storeString=storeString+ strInput[i];
            }

        
              lblDisplay.Text = Convert.ToString(storeString);
              storeString = "";
           
        }
        private void button40_Click(object sender, EventArgs e) //Truncate
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = Convert.ToString(Math.Truncate(firstnum));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button41_Click(object sender, EventArgs e) // ceiling
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = System.Convert.ToString(Math.Ceiling(firstnum));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button50_Click(object sender, EventArgs e) //floor
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = System.Convert.ToString(Math.Floor(firstnum));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button39_Click(object sender, EventArgs e)  //Round
        {
            try
            {
                firstnum = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = System.Convert.ToString(Math.Round(firstnum));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button44_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = Convert.ToString(firstnum*firstnum*firstnum);
        }

        //----------------------------Age Calculation----------------------------------------------
        private void button45_Click(object sender, EventArgs e) //age Button
        {
              pday = Convert.ToDouble(textBox1.Text);
              pmonth = Convert.ToDouble(textBox2.Text);
              pyear = Convert.ToDouble(textBox3.Text);

              bday = Convert.ToDouble(textBox4.Text);
              bmonth = Convert.ToDouble(textBox5.Text);
              byear = Convert.ToDouble(textBox6.Text);
                    if (pday >= bday)
                        {
                            D = pday - bday+1;
                        }

                    else
                        {
                            pday = pday + 30;
                            D = pday - bday+1;
                            bmonth = bmonth + 1;
                        }

                    if (pmonth >= bmonth)
                        {
                            M = pmonth - bmonth;

                        }

                    else
                        {
                            pmonth = pmonth + 12;
                            M = pmonth - bmonth;
                            byear = byear + 1;
                        }

                    if (pyear > byear)
                        {
                            Y = pyear - byear;
                        }
                    lblDisplay.Text = "You are "+Y+" years "+M+" months and "+D+" days.";
                 
        }

       
        //---------------------------------------------------------------------------------------------------------
        //---------------------------------Convertion------------------------------------------------------------------------
        private void button46_Click(object sender, EventArgs e) //Dec
        {
           
           switch (op) 
            {
                case'B':  // Binary to Dec Case

                    lblDisplay.Text = Convert.ToString(Convert.ToInt64(b1, 2),10);
                 
                    break;
                case 'H':   //Hex to Dec Case

                    lblDisplay.Text = Convert.ToString(Convert.ToInt64(h1, 16), 10);
                   
                    break;
                case 'O': // Oct to Dec Case

                    lblDisplay.Text = Convert.ToString(Convert.ToInt64(o1, 8), 10);
                
                    break;
            }

           d1 = lblDisplay.Text;
           op = 'D';
        }

      //---------------------------------------------------------------------------------------------------------
        private void button47_Click(object sender, EventArgs e)  //Oct
        {
                  
       switch (op)  //Dec to Oct switch() --------
           {
               case 'D': 
                    lblDisplay.Text = Convert.ToString(Convert.ToInt64(d1, 10), 8);
                  
                    break;               
              case 'H':
                        lblDisplay.Text = Convert.ToString(Convert.ToInt64(h1, 16), 8);
                
                        break;
                            
               case 'B':   
                           lblDisplay.Text = Convert.ToString(Convert.ToInt64(b1, 2), 8);
                
                           break;
                   }
                
                 o1 = lblDisplay.Text; 
                 op='O';
                
               

        }

        //---------------------------------------------------------------------------------------------------------
        private void button48_Click(object sender, EventArgs e)  // Hex
        {
                              
           switch (op)   //Dec to Hex switch()-----------
             {
               case 'D':       
                   lblDisplay.Text = Convert.ToString(Convert.ToInt64(d1, 10), 16);
                 
                   break;            
                  
               case 'O':  
                   lblDisplay.Text = Convert.ToString(Convert.ToInt64(o1, 8), 16);
                  
                   break;
   
              case 'B':
                   lblDisplay.Text = Convert.ToString(Convert.ToInt64(b1, 2), 16);
                
                   break;
           }

            h1 = lblDisplay.Text;
            op='H';
            
        }

        //---------------------------------------------------------------------------------------------------------
        private void button49_Click(object sender, EventArgs e)  // Binary
        {
           
            switch (op) //Dec to Binary switch()-------------
            {
                case 'D':   
                  
                    lblDisplay.Text = Convert.ToString(Convert.ToInt64(d1, 10), 2);
                   
                    break;

              case 'H':
                  lblDisplay.Text = Convert.ToString(Convert.ToInt64(h1, 16), 2);
              
                  break;

              case 'O':
                  lblDisplay.Text = Convert.ToString(Convert.ToInt64(o1, 8), 2);
                
                  break;
          }   

          b1 = lblDisplay.Text;
          op = 'B';
          

        }

   
        //--------------------------------------------------------------------------

        private void button51_Click(object sender, EventArgs e) // A button
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "a";

            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "a";
            }
        }

        private void button52_Click(object sender, EventArgs e)// B button
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "b";

            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "b";
            }
        }

        private void button53_Click(object sender, EventArgs e)// C button
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "c";

            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "c";
            }
        }

        private void button54_Click(object sender, EventArgs e)// D button
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "d";

            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "d";
            }
        }

        private void button55_Click(object sender, EventArgs e) // E button
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "e";

            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "e";
            }
        }

        private void button56_Click(object sender, EventArgs e) // F button
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "f";

            }

            else
            {
                lblDisplay.Text = Convert.ToString(lblDisplay.Text) + "f";
            }
        }

        //--------------------------------------------------------------------------
        //--------------------------------------------------------------------------
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        } 

        //--------------------------------------------------------------------------
        
    }
 }
