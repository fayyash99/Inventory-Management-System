using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    class Insertion
    {
        //For User Insertion
        public void InsertUser(string name,string username,string pass,string phone,string email,Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@username",username);
                cmd.Parameters.AddWithValue("@pwd",pass);
                cmd.Parameters.AddWithValue("@phone",phone);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name+"Added to be System Successfully", "Success.....", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message,"Error.....","Error");
            }
        }
        //For Category Insertion
        public void InsertCategory(string name,Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name+ "Added to be System Successfully", "Success.....", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error.....", "Error");
            }
        }
        //For product Insertion
        public void InsertProduct(string product, string barcode, int catID, DateTime? expire=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProduct", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                if (expire == null)
                {
                    cmd.Parameters.AddWithValue("@expire", DBNull.Value);
                }
                else 
                {
                    cmd.Parameters.AddWithValue("@expire", expire);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product+ "Added to be System Successfully", "Success.....", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error.....", "Error");
            }
        }
        //For Supplier Insertion
        public void InsertSupplier(string company, string person, string phone1, string address, Int16 status,string phone2 = null,string ntn =null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@conPerson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else 
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }
                cmd.Parameters.AddWithValue("@address", address);
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(company + " Added to be System Successfully", "Success.....", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error.....", "Error");
            }
        }
        //For Purcahse Insertion
        private Int64 PurchaseInvoiceID;
        public Int64 InsertPurchaseInvoice(DateTime date, int doneBy, int suppID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneBy", doneBy);
                cmd.Parameters.AddWithValue("@suppID", suppID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "st_getLastPurchaseID";
                cmd.Parameters.Clear();
                PurchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error.....", "Error");
            }
            return PurchaseInvoiceID;
        }
        //For Purcahse Details
        int pidCount;
        public int InsertPurchaseInvoiceDetails(Int64 purID, int proID, int quantity, float totprice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID", purID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@totprice", totprice);
                MainClass.con.Open();
                pidCount = cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
            }
            return pidCount;
        }
        //For Insert Stock
        public void InsertStock(int proID, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
            }
        }
        //For delete data insert
        public void InsertDeletedItem(Int64 pid, int proid, int userid, int quan, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemsPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@piID", pid);
                cmd.Parameters.AddWithValue("@usrID", userid);
                cmd.Parameters.AddWithValue("@proID", proid);
                cmd.Parameters.AddWithValue("@quantity", quan);
                cmd.Parameters.AddWithValue("@date", date);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error.....", "Error");
            }
        }
        //For product price insert
        public void InsertProductPrice(int proID, float buyingAmoun)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", buyingAmoun);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error.....", "Error");
            }
        }
        //For Sales insertion
        int salCount = 0;
        Int64 salesID;
        retrival r = new retrival();
        Updation u = new Updation();
        public void InsertSales(DataGridView gv,String proIDgv,String proQuantityGV, string pupgv, string disgv, int doneby, DateTime date,float totalAamount,float totalDis,float amtGiven,float amtReturn,String payType)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done", doneby);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@totalamount", totalAamount);
                    cmd.Parameters.AddWithValue("@totaldis", totalDis);
                    cmd.Parameters.AddWithValue("@given", amtGiven);
                    cmd.Parameters.AddWithValue("@return", amtReturn);
                    if (payType == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@payType", 0);
                    }
                    else if (payType == "Credit Card") 
                    {
                        cmd.Parameters.AddWithValue("@payType", 1);
                    }

                    MainClass.con.Open();
                    salCount = cmd.ExecuteNonQuery();
                    if (salCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", MainClass.con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        salesID = Convert.ToInt64(cmd2.ExecuteScalar());
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSalesDetails", MainClass.con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salID", salesID);
                            cmd3.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDgv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells[proQuantityGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@sellingprice", Convert.ToDouble(row.Cells[pupgv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@discountprice", Convert.ToDouble(row.Cells[disgv].Value.ToString()));
                            cmd3.ExecuteNonQuery();
                            int stockofProduct = Convert.ToInt32(r.getProductQuantityWithoutConnection(Convert.ToInt64(row.Cells[proIDgv].Value.ToString())));
                            int currentQuanofProduct = Convert.ToInt32(row.Cells[proQuantityGV].Value.ToString());
                            int finalProductQuantity = stockofProduct - currentQuanofProduct;
                            u.updateStockWithoutConnection(Convert.ToInt64(row.Cells[proIDgv].Value.ToString()),finalProductQuantity);
                        }
                    }
                    MainClass.con.Close();
                    MainClass.ShowMSG("Sales SuccessFull","Success","Success");
                    sc.Complete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MainClass.con.Close();
            }
        }

        //For sale refund Invoice
        private int refundCount;
        public int insertReturnRefund(Int64 salesID, DateTime dt, int doneBy, Int64 proID, Int16 quan, float refundAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertRefundsReturns", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID", salesID);
                cmd.Parameters.AddWithValue("@date", dt);
                cmd.Parameters.AddWithValue("@doneby", doneBy);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quantity", quan);
                cmd.Parameters.AddWithValue("@refAmount", refundAmount);
                MainClass.con.Open();
                refundCount = cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return refundCount;
        }
    }
}
