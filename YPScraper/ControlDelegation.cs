using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YPScraper
{
    public static class ControlDelegation
    {
        public delegate void SetText(string text, Control ctrl);

        public delegate void Enable(Control ctrl);

        public delegate void Disable(Control ctrl);

        public delegate void Add(Control parent, Control child);

        public delegate void Remove(Control parent, Control child);

        public delegate void RemoveName(Control parent, string child);

        public delegate void Top(Control ctrl, int top);

        public delegate void AddItemHandler(ListBox ctrl, object item);

        public delegate void ClearItemsHandler(ListBox ctrl);

        public static Top ControlTop = new Top(SetTop);

        private static void SetTop(Control ctrl, int top)
        {
            ctrl.Top = top;
        }

        public static Add ControlAdd = new Add(AddControl);

        public static Remove ControlRemove = new Remove(RemoveControl);

        public static RemoveName ControlRemoveName = new RemoveName(RemoveNameControl);

        public static AddItemHandler ControlAddItem = new AddItemHandler(AddItem);

        public static ClearItemsHandler ControlClearItems = new ClearItemsHandler(ClearItems);


        private static void ClearItems(ListBox ctrl)
        {
            ctrl.Items.Clear();
        }

        static void AddItem(ListBox ctrl, object item)
        {
            ctrl.Items.Add(item);
        }

        private static void RemoveNameControl(Control parent, string child)
        {
            parent.Controls.RemoveByKey(child);
        }

        private static void AddControl(Control parent, Control child)
        {
            parent.Controls.Add(child);
        }

        private static void RemoveControl(Control parent, Control child)
        {
            parent.Controls.Remove(child);
        }

        public static Enable ControlEnable = new Enable(EnableControl);

        public static Disable ControlDisable = new Disable(DisableControl);

        public static SetText TextSetter = new SetText(SetControlText);

        private static void EnableControl(Control ctrl)
        {
            ctrl.Enabled = true;
        }

        private static void DisableControl(Control ctrl)
        {
            ctrl.Enabled = false;
        }

        private static void SetControlText(string text, Control ctrl)
        {
            ctrl.Text = text;
        }

        public static void DEnable(this Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(ControlEnable, ctrl);
            }
            else
            {
                ctrl.Enabled = true;
            }
        }

        public static void DDisable(this Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(ControlDisable, ctrl);
            }
            else
            {
                ctrl.Enabled = false;
            }
        }

        public static void DSetText(this Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(TextSetter, text, ctrl);
            }
            else
            {
                ctrl.Text = text;
            }
        }

        public static void DAddControl(this Control ctrl, Control child)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(ControlAdd, ctrl, child);
            }
            else
            {
                ctrl.Controls.Add(child);
            }
        }

        public static void DRemoveControl(this Control ctrl, Control child)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(ControlRemove, ctrl, child);
            }
            else
            {
                ctrl.Controls.Remove(child);
            }
        }

        public static void DRemoveControlByName(this Control ctrl, string child)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(ControlRemoveName, ctrl, child);
            }
            else
            {
                ctrl.Controls.RemoveByKey(child);
            }
        }

        public static void DSetTop(this Control ctrl, int top)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(ControlTop, ctrl, top);
            }
            else
            {
                ctrl.Top = top;
            }
        }

        public static void DAddItem(this ListBox ctrl, object item)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(ControlAddItem, ctrl, item);
            }
            else
            {
                ctrl.Items.Add(item);
            }
        }

        public static void DClearItems(this ListBox ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(ControlClearItems, ctrl);
            }
            else
            {
                ctrl.Items.Clear();
            }
        }
    }
}
