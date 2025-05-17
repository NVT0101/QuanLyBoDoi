using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public static class Common
    {
        public static string CurentDB;
        public static string outPath;
        public static void BindEnumToCombobox<T>(this ComboBox comboBox, T defaultSelection)
        {
            try
            {
                var list = Enum.GetValues(typeof(T)).Cast<T>().Select(value => new { Description = (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description ?? value.ToString(), Value = value }).OrderBy(item => item.Value.ToString()).ToList();
                comboBox.DataSource = list;
                comboBox.DisplayMember = "Description";
                comboBox.ValueMember = "Value";
                foreach (var opts in list)
                {
                    if (opts.Value.ToString() == defaultSelection.ToString())
                    {
                        comboBox.SelectedItem = opts;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "BindEnumToCombobox", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static void BindEnumToTableBand<T>(this DataGridViewComboBoxColumn comboBox)
        {
            try
            {
                var list = Enum.GetValues(typeof(T)).Cast<T>().Select(value => new { Description = (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description ?? value.ToString(), Value = value }).OrderBy(item => item.Value.ToString()).ToList();
                comboBox.DataSource = list;
                comboBox.DisplayMember = "Description";
                comboBox.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "BindEnumToTableBand", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static string GetEnumDescription(Enum value)
        {
            try
            {
                FieldInfo fi = value.GetType().GetField(value.ToString());
                DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
                if (attributes != null && attributes.Any())
                {
                    return attributes.First().Description;
                }

                return value.ToString();
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "GetEnumDescription", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return "";
            }
        }
    }
}