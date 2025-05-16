using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public partial class MainForm
    {
        public void AddViewDataSource(List<People> people)
        {
            var source = new BindingSource();

            foreach (var p in people)
            {
                source.Add(p);
            }

            TuyenHuanDataView.DataSource = source;
        }
        private void SelectTemplate(object sender, EventArgs e)
        {
            try
            {
                //LoadMau ld = new LoadMau();

                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod($"LoadMau{ListTemplate.SelectedIndex + 1}");
                theMethod.Invoke(this, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
