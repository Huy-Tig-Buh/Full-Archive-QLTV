using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyThuVien
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /*try
            {
                if (Session["role"].Equals(""))
                {
                    Btn_UserLogin.Visible = true; // user login link button
                    Btn_SignUp.Visible = true; // sign up link button

                    Btn_Logout.Visible = false; // logout link button
                    Btn_Hello.Visible = false; // hello user link button


                    Btn_AdminLogin.Visible = true; // admin login link button
                    Btn_AuthorManegerment.Visible = false; // author management link button
                    Btn_Publisher.Visible = false; // publisher management link button
                    Btn_BookIssuing.Visible = false; // book inventory link button
                    Btn_BookIssuing.Visible = false; // book issuing link button
                    Btn_MemberManagement.Visible = false; // member management link button

                }
                else if (Session["role"].Equals("user"))
                {
                    Btn_UserLogin.Visible = false; // user login link button
                    Btn_SignUp.Visible = false; // sign up link button

                    Btn_Logout.Visible = true; // logout link button
                    Btn_Hello.Visible = true; // hello user link button
                    Btn_Hello.Text = "Hello " + Session["username"].ToString();


                    Btn_AdminLogin.Visible = true; // admin login link button
                    Btn_AuthorManegerment.Visible = false; // author management link button
                    Btn_Publisher.Visible = false; // publisher management link button
                    Bnt_BookInventory.Visible = false; // book inventory link button
                    Btn_BookIssuing.Visible = false; // book issuing link button
                }
                else if (Session["role"].Equals("admin"))
                {
                    Btn_UserLogin.Visible = false; // user login link button
                    Btn_SignUp.Visible = false; // sign up link button

                    Btn_Logout.Visible = true; // logout link button
                    Btn_Hello.Visible = true; // hello user link button
                    Btn_Hello.Text = "Hello Admin";


                    Btn_AdminLogin.Visible = false; // admin login link button
                    Btn_AuthorManegerment.Visible = true; // author management link button
                    Btn_Publisher.Visible = true; // publisher management link button
                    Bnt_BookInventory.Visible = true; // book inventory link button
                    Btn_BookIssuing.Visible = true; // book issuing link button
                }
            }
            catch (Exception )
            {

            }*/
            
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormaneger.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermaneger.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuaing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanegerment.aspx");
        }
        //logout button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            Btn_UserLogin.Visible = true; // user login link button
            Btn_SignUp.Visible = true; // sign up link button

            Btn_Logout.Visible = false; // logout link button
            Btn_Hello.Visible = false; // hello user link button


            Btn_AdminLogin.Visible = true; // admin login link button
            Btn_AuthorManegerment.Visible = false; // author management link button
            Btn_Publisher.Visible = false; // publisher management link button
            Bnt_BookInventory.Visible = false; // book inventory link button
            Btn_BookIssuing.Visible = false; // book issuing link button
            Btn_MemberManagement.Visible = false; // member management link button
        }

        // view profile
        protected void LinkButton7_Click(object sender, EventArgs e)
        {

        }
    }
}