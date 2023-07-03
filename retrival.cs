using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    class retrival
    {
        //For User Show
        public void ShowUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn NameGV, DataGridViewColumn UsernamGV, DataGridViewColumn PasswordGV, DataGridViewColumn PhoneGV, DataGridViewColumn EmailGV, DataGridViewColumn StatusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUsersData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUsersDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd); //responsible for excute query in cmd
                DataTable dt = new DataTable(); //GV accept data table
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                UsernamGV.DataPropertyName = dt.Columns["Username"].ToString();
                PasswordGV.DataPropertyName = dt.Columns["Password"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                EmailGV.DataPropertyName = dt.Columns["Email"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }
        //For Category Show
        public void ShowCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn StatusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd); //responsible for excute query in cmd
                DataTable dt = new DataTable(); //GV accept data table
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data", "Error....", "Error");
            }
        }
        //For Category List
        public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb.DisplayMember = displayMember; //Front end
                cb.ValueMember = valueMember; //back end
                cb.DataSource = dt;
                cb.SelectedIndex = -1;


            }
            catch (Exception)
            {

            }
        }
        //For product Show
        public void ShowProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn expireGV, DataGridViewColumn catGV, DataGridViewColumn barcodeGV, DataGridViewColumn catIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd); //responsible for excute query in cmd
                DataTable dt = new DataTable(); //GV accept data table
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expireGV.DataPropertyName = dt.Columns["Expire"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.ShowMSG(e.Message + "\t Unable to load categories data", "Error....", "Error");
            }
        }
        //for database is private & encapsulation is public
        //For Login/logout
        public static int USER_ID
        {
            get;
            private set;
        }
        public static String EMP_NAME
        {
            get;
            private set;
        }
        //For sale report
        public void showReport(String reportName,ReportDocument rd,CrystalReportViewer crv,String proc, String parameter1, Object val1)
        {
            try 
            {
                SqlCommand cmd = new SqlCommand(proc,MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parameter1,val1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\"+reportName);
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch (Exception ex) 
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        private static string user_name = null, pass_word = null;
        private static bool checkLogin;
        //Method call for Login window 
        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@password", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader(); //only data retrive
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["User Name"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word == password)
                        {
                            MainClass.ShowMSG("Invalid Username", "Error...", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Password", "Error...", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Username and Password", "Error...", "Error");
                        }
                    }
                }
                MainClass.con.Close();

            }

            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.ShowMSG("Unable to Login...", "Error", "Error");
            }
            return checkLogin;
        }
        //For Show Supplier
        public void ShowSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn comNameGV, DataGridViewColumn personnamGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd); //responsible for excute query in cmd
                DataTable dt = new DataTable(); //GV accept data table
                da.Fill(dt);
                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                comNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personnamGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load Supplier data", "Error....", "Error");
            }
        }
        //For Product by barcode
        private string[] productsData = new string[6];
        public string[] getProductWRTbarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                        {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString(); //proID
                        productsData[1] = dr[1].ToString(); //product name
                        productsData[2] = dr[2].ToString(); //barcode
                        productsData[3] = dr[3].ToString(); //selling price
                        productsData[4] = dr[4].ToString(); //Discount
                        productsData[5] = dr[5].ToString(); //final selling price
                    }

                }
                else
                {
                    Array.Clear(productsData,0,productsData.Length);
                }
                MainClass.con.Close();

            }
            catch (Exception)
            {

            }
            return productsData;
        }
        //For Purchase Details
        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Category" };
                dt.Rows.InsertAt(dr, 0);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember; //Front end
                cb.ValueMember = valueMember; //back end

            }
            catch (Exception ex)
            {

            }
        }
        //For stock quantity count
        private object productStockCount = 0;
        public object getProductQuantity(int proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                productStockCount = Convert.ToInt32(cmd.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception ex)
            { 
            }
            return productStockCount;
        }
        public object getProductQuantityWithoutConnection(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                productStockCount = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
            }
            return productStockCount;
        }
        //For Show purchase
        public void ShowPurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn mPIDGV, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn quantityGV, DataGridViewColumn pupGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd); //responsible for excute query in cmd
                DataTable dt = new DataTable(); //GV accept data table
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.ShowMSG(e.Message + "\t Unable to load categories data", "Error....", "Error");
            }
            }
        //For show Stock
        public void ShowStocksDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, DataGridViewColumn barcodeGV, DataGridViewColumn expireGV, DataGridViewColumn bprGV, DataGridViewColumn spGV, DataGridViewColumn catGV, DataGridViewColumn availStGV, DataGridViewColumn statusGV, DataGridViewColumn totGV)
        {
            try
            { 
                SqlCommand cmd = new SqlCommand("st_getAllStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd); //responsible for excute query in cmd
                DataTable dt = new DataTable(); //GV accept data table
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expireGV.DataPropertyName = dt.Columns["Expire Date"].ToString();
                bprGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category Name"].ToString();
                availStGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load Stock data", "Error....", "Error");
            }
        }
        public void ShowProductWRTCategory(int catID,DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn disGV, DataGridViewColumn profitPerGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductWRTCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", catID);
                SqlDataAdapter da = new SqlDataAdapter(cmd); //responsible for excute query in cmd
                DataTable dt = new DataTable(); //GV accept data table
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selleing Price"].ToString();
                disGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitPerGV.DataPropertyName = dt.Columns["Profit Per"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.ShowMSG("Unable to load Products data", "Error....", "Error");
            }
        }

        //private bool checkPPExistance;
        private object[] productPriceDetails = new object[5];
        public object[] checkProductPriceExistance(int proID) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                        productPriceDetails[0] = dt.Rows[0][0].ToString(); //proID
                        productPriceDetails[1] = dt.Rows[0][1].ToString(); //bp
                        productPriceDetails[2] = dt.Rows[0][2].ToString(); //sp
                        productPriceDetails[3] = dt.Rows[0][3].ToString(); //disPercentage
                        productPriceDetails[4] = dt.Rows[0][4].ToString(); //profitPercentage
                    
                }
                else 
                {
                    Array.Clear(productPriceDetails,0,productPriceDetails.Length);
                }
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return productPriceDetails;
        }
        //Show sales
        public void ShowDailySales(DateTime date,DataGridView gv, DataGridViewColumn saleIDGV, DataGridViewColumn userGV, DataGridViewColumn totAmtGV, DataGridViewColumn totDisGV, DataGridViewColumn AmtgivenGV, DataGridViewColumn AmtreturnGV, DataGridViewColumn userIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDailySales", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd); //responsible for excute query in cmd
                DataTable dt = new DataTable(); //GV accept data table
                da.Fill(dt);
                saleIDGV.DataPropertyName = dt.Columns["Sale ID"].ToString();
                userGV.DataPropertyName = dt.Columns["User name"].ToString();
                totAmtGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                totDisGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                AmtgivenGV.DataPropertyName = dt.Columns["Amount Received"].ToString();
                AmtreturnGV.DataPropertyName = dt.Columns["Cash Back"].ToString();
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.ShowMSG(e.Message + "\t Unable to load categories data", "Error....", "Error");
            }
        }
        //For sale return
        public void ShowSalesDataViaID(Int64 salesID, DataGridView gv, DataGridViewColumn salesIDGV, DataGridViewColumn barcodeGV, DataGridViewColumn productGV, 
            DataGridViewColumn quantityGV, DataGridViewColumn proPriceGV, DataGridViewColumn perProdisGV, DataGridViewColumn perProTotGV, 
            DataGridViewColumn totDisGV, DataGridViewColumn totAmountGV, DataGridViewColumn AmtGivenGV, 
            DataGridViewColumn AmtReturnGV, DataGridViewColumn dateGV, DataGridViewColumn usrGV, DataGridViewColumn payMethodGV, DataGridViewColumn proIDGv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSalesReceiptWRTSalesID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID",salesID);
                SqlDataAdapter da = new SqlDataAdapter(cmd); //responsible for excute query in cmd
                DataTable dt = new DataTable(); //GV accept data table
                da.Fill(dt);
                salesIDGV.DataPropertyName = dt.Columns["Sale ID"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                productGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                proPriceGV.DataPropertyName = dt.Columns["Product Price"].ToString();
                perProdisGV.DataPropertyName = dt.Columns["Per Product Discount"].ToString();
                perProTotGV.DataPropertyName = dt.Columns["Per Product Total"].ToString();
                totDisGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                AmtGivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();
                AmtReturnGV.DataPropertyName = dt.Columns["Amount Returned"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                usrGV.DataPropertyName = dt.Columns["User"].ToString();
                payMethodGV.DataPropertyName = dt.Columns["Pay Type"].ToString();
                proIDGv.DataPropertyName = dt.Columns["Product ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MainClass.ShowMSG(e.Message + "\t Unable to load categories data", "Error....", "Error");
            }
        }



        
        }
}
