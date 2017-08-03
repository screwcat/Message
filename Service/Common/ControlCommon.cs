using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Message.Model;
using System.Data;

namespace Service.Common
{
    public static class ControlCommon
    {
        /// <summary>
        /// 绑定折扣
        /// </summary>
        /// <param name="cb"></param>
        public static void BindDiscount(ComboBox cb)
        {
            Discount dsc = new Discount();
            List<string[]> liWhere = new List<string[]>();
            List<string[]> liOrder = new List<string[]>();
            liWhere.Add(new string[] { "Available = '{0}'", "True" });
            liOrder.Add(new string[] { "DiscountRate", "DESC" });
            DataTable dt = dsc.GetDataSet("SELECT DiscountRate, DisName FROM Discount", liWhere, liOrder);
            cb.DisplayMember = "DisName";
            cb.ValueMember = "DiscountRate";
            cb.DataSource = dt;
            cb.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定会员卡类型
        /// </summary>
        /// <param name="cb"></param>
        public static void BindCardType(ComboBox cb)
        {
            CardType ct = new CardType();
            List<string[]> liWhere = new List<string[]>();
            List<string[]> liOrder = new List<string[]>();
            liWhere.Add(new string[] { "Available = '{0}'", "1" });
            liOrder.Add(new string[] { "ID", "ASC" });
            DataTable dt = ct.GetDataSet("SELECT ID, TypeName FROM CardType", liWhere, liOrder);
            cb.DisplayMember = "TypeName";
            cb.ValueMember = "ID";
            cb.DataSource = dt;
            cb.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定人员
        /// </summary>
        /// <param name="cb"></param>
        public static void BindEmployee(ComboBox cb)
        {
            Employee emp = new Employee();
            List<string[]> liWhere = new List<string[]>();
            List<string[]> liOrder = new List<string[]>();
            liWhere.Add(new string[] { "1 = '{0}'", "1" });
            liOrder.Add(new string[] { "Employee_ID", "DESC" });
            DataTable dt = emp.GetDataSet("SELECT Employee_ID, Name FROM Employee", liWhere, liOrder);
            cb.DisplayMember = "Name";
            cb.ValueMember = "Employee_ID";
            cb.DataSource = dt;
        }



        /// <summary>
        /// 绑定商品名
        /// </summary>
        /// <param name="cb"></param>
        public static void BindProduct(ComboBox cb)
        {
            Product emp = new Product();
            List<string[]> liWhere = new List<string[]>();
            List<string[]> liOrder = new List<string[]>();
            liWhere.Add(new string[] { "1 = '{0}'", "1" });
            liOrder.Add(new string[] { "Product_ID", "DESC" });
            DataTable dt = emp.GetDataSet("SELECT Product_ID, Name FROM Product", liWhere, liOrder);
            cb.DisplayMember = "Name";
            cb.ValueMember = "Product_ID";
            cb.DataSource = dt;
        }


        /// <summary>
        /// 正整数和负整数
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="e"></param>
        public static void VerDigitalHL(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == (char)45)
                {
                    if (((TextBox)sender).Text.StartsWith("-"))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        /// <summary>
        /// 只能输入正整数
        /// </summary>
        /// <param name="e"></param>
        public static void VerDigital(KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 只能输入两位小数的数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void VerDecimal(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;  //小数点的处理。
            }
            //else
            //{
            //    if ((int)e.KeyChar != 8)
            //    {
            //        if (((TextBox)sender).Text.Contains("."))
            //        {
            //            string[] SectionText = ((TextBox)sender).Text.Split(new char[] { '.' });
            //            if (SectionText[1].Length > 1)
            //            {
            //                e.Handled = true;
            //            }
            //        }

            //    }
            //}
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (((TextBox)sender).Text.Length <= 0)
                { e.Handled = true; }   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(((TextBox)sender).Text, out oldf);
                    b2 = float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                        { e.Handled = true; }
                        else
                        { e.Handled = false; }
                    }
                }
            }
        }
    }
}
