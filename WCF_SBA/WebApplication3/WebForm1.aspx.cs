using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.ServiceReference1;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IsupliermanagerClient proxy = new IsupliermanagerClient();
            SUPPLIER sup = new SUPPLIER();
            sup.SUPLNO =Convert.ToInt32(TextBox1.Text);
            sup.SUPLNAME = TextBox2.Text;
            sup.SUPLADDR= TextBox3.Text;
            proxy.add(sup);
            Label4.Text = "data added";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            IsupliermanagerClient proxy = new IsupliermanagerClient();
            var id = int.Parse(TextBox1.Text);
            var data = proxy.GetUPPLIER(id);
            TextBox2.Text = data.SUPLNAME;
            TextBox3.Text = data.SUPLADDR;
            proxy.update(data);
            Label4.Text = "edited";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            IsupliermanagerClient proxy = new IsupliermanagerClient();
            var id = int.Parse(TextBox1.Text);
            var data = proxy.GetUPPLIER(id);
            if (id == data.SUPLNO)
            {
                proxy.delete(id);
                Label4.Text = "deleted";
            }
            else
            {
                Label1.Text = "not present";
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            IsupliermanagerClient proxy = new IsupliermanagerClient();
            var data = proxy.GetSUPPLIERs();
            GridView1.DataSource = data.ToList();
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            IsupliermanagerClient proxy = new IsupliermanagerClient();
            var id = int.Parse(TextBox1.Text);
            var data = proxy.GetUPPLIER(id);
            Label4.Text = data.SUPLNAME;
            Label5.Text = data.SUPLADDR;

        }
    }
}