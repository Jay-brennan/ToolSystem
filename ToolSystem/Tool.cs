using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolSys
    {
        class Tool
        {
            //variables
            private int Tool_ID;
            private String Tool_Name;
            private String Description;
            private decimal Price;
            private Char Status;


           
            public Tool()
            {
                Tool_ID =0;
                Tool_Name="";
                Description = "";
                Price = 0;
                Status = 'A';

            }

           

            public Tool(int Tool_ID,String Tool_Name, String Description, decimal Price, Char Status)
            {
                this.Tool_ID = Tool_ID;
                this.Tool_Name = Tool_Name;
                this.Description = Description;
                this.Price = Price;
                this.Status = Status;
            }

            public void setToolID(int Tool_ID)
            {
                this.Tool_ID = Tool_ID;
            }

            public static DataSet getTools(DataSet DS, String searched)
            {
                
                OracleConnection conn = new OracleConnection(DBConnect.orDB);

                
                String strSQL = "SELECT * From Tool WHERE Tool_Name LIKE '%"+ searched+"%' OR Description LIKE '%" + searched +"%'";

                
                OracleCommand cmd = new OracleCommand(strSQL, conn);

               
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                
                da.Fill(DS, "stk");

                
                conn.Close();

             
                return DS;

            }

            
         

            public void addTool()
            {
               
                OracleConnection myConn = new OracleConnection(DBConnect.orDB);
                myConn.Open();

                
                String strSQL = "INSERT INTO TOOL Values(" + this.Tool_ID + ",'" + this.Tool_Name + "','" + this.Description + "'," + this.Price + ",'" + this.Status + "')";

               
                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                cmd.ExecuteNonQuery();

               
                myConn.Close();


            }
                            
            public static int incrementToolNum()
            {   
                int nextStockNo = 1;
               
                OracleConnection myConn = new OracleConnection(DBConnect.orDB);
                myConn.Open();
            
                String strSQL = "SELECT MAX (Tool_ID) FROM Tool";
                OracleCommand cmd = new OracleCommand(strSQL, myConn);

               
                OracleDataReader dr = cmd.ExecuteReader();

                
                dr.Read();

                
                if (dr.IsDBNull(0))
                {
                    nextStockNo = 1;
                }
                else
                {
                    nextStockNo = Convert.ToInt32(dr.GetValue(0)) + 1;
                }
                
                myConn.Close();

                return nextStockNo;

            }

            public void updateTool()
            {
                
                OracleConnection myConn = new OracleConnection(DBConnect.orDB);
                myConn.Open();

               
                String strSQL = "UPDATE Tool SET Description ='" + this.Description + "',Price =" + this.Price + " WHERE Tool_ID =" + this.Tool_ID;

              
                OracleCommand cmd = new OracleCommand(strSQL, myConn);
                cmd.ExecuteNonQuery();

                
                myConn.Close();
            }



        public static Boolean toolNameVal(String name)
        {
            Regex toolVal = new Regex("^[a-zA-Z ]*$");

            if (!toolVal.IsMatch(name))
            {
                MessageBox.Show("Tool name can only contain characters!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        public static Boolean descriptionVal(String desc)
        {
            Regex descVal = new Regex("^[a-zA-Z ,. ]*$");

            if (!descVal.IsMatch(desc))
            {
                MessageBox.Show("Tool Description cannot contain numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean priceVal(String prc)
        {

           decimal value = Convert.ToDecimal(prc);

            if (value == 0)
            {
                MessageBox.Show("Price cannot be 0 or lower!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }
        



    }
    }



