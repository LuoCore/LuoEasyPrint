using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace LuoEasyPrint
{
    // Token: 0x02000033 RID: 51
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class MoveControl : IDisposable
    {
        // Token: 0x060007FA RID: 2042 RVA: 0x000488E0 File Offset: 0x00046AE0
        public MoveControl()
        {
            this._IsShitKey = false;
            this._IsCtrlKey = false;
            this.Rh = null;
            this.Rv = null;
            this._textbox = new TextBox[1501];
            this._MControl = null;
            this._IsMouseDown = false;
            this.BOX_COLOR = Color.White;
            this.BOX_CurrentSelectedColor = Color.Black;
            this.BOX_LINECOLOR = Color.Red;
            this._lbl = new Label[1501, 9];
            this.myselectzt = new bool[1501];
            this._arrArrow = new Cursor[]
            {
                Cursors.SizeNWSE,
                Cursors.SizeNS,
                Cursors.SizeNESW,
                Cursors.SizeWE,
                Cursors.SizeNWSE,
                Cursors.SizeNS,
                Cursors.SizeNESW,
                Cursors.SizeWE,
                Cursors.SizeAll
            };
            this.MyControl = new Control[1501];
            this.PreRect = new Rectangle[1501];
            this.NewRect = new Rectangle[1501];
            this.mypos = new Rectangle[1501];
            this.ishandlemousedown = false;
        }

        // Token: 0x14000001 RID: 1
        // (add) Token: 0x060007FB RID: 2043 RVA: 0x00004215 File Offset: 0x00002415
        // (remove) Token: 0x060007FC RID: 2044 RVA: 0x0000422E File Offset: 0x0000242E
        public event MoveControl.ShowStatusEventHandler ShowStatus;

        // Token: 0x060007FD RID: 2045 RVA: 0x00004247 File Offset: 0x00002447
        public void ResetMyPos(Control cc)
        {
            this.mypos[this.GetControlIndex(cc)].X = cc.Left;
            this.mypos[this.GetControlIndex(cc)].Y = cc.Top;
        }

        // Token: 0x060007FE RID: 2046 RVA: 0x00048A10 File Offset: 0x00046C10
        private void Control_LocationChanged(object sender, EventArgs e)
        {
            if (!this.ishandlemousedown)
            {
                int controlIndex = this.GetControlIndex((Control)sender);
                this.CheckControlPos(this.MyControl[controlIndex]);
                try
                {
                    this.MoveHandles(controlIndex);
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x060007FF RID: 2047 RVA: 0x00048A68 File Offset: 0x00046C68
        private void Control_SizeChanged(object sender, EventArgs e)
        {
            if (!this.ishandlemousedown)
            {
                int controlIndex = this.GetControlIndex((Control)sender);
                this.CheckControlPos(this.MyControl[controlIndex]);
                try
                {
                    this.MoveHandles(controlIndex);
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x06000800 RID: 2048 RVA: 0x00048AC0 File Offset: 0x00046CC0
        public void Clear()
        {
            checked
            {
                try
                {
                    int num = 0;
                    do
                    {
                        this.DeleteControl(num);
                        num++;
                    }
                    while (num <= 1500);
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x06000801 RID: 2049 RVA: 0x00048B04 File Offset: 0x00046D04
        public void DeleteSelectedControl()
        {
            int[] selectedAllControls = this.GetSelectedAllControls();
            checked
            {
                if (selectedAllControls != null && Interaction.MsgBox("您确定要删除本次选中的共〖" + Convert.ToString(selectedAllControls.Length) + "〗个控件吗？", MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question, "提示信息") == MsgBoxResult.Yes)
                {
                    int num = 0;
                    int num2 = selectedAllControls.Length - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        this.DeleteControl(selectedAllControls[i]);
                    }
                }
            }
        }

        // Token: 0x06000802 RID: 2050 RVA: 0x00048B5C File Offset: 0x00046D5C
        public void DeleteControl(int ctrlindex)
        {
            Control control = this.GetControl(ctrlindex);
            checked
            {
                if (control != null)
                {
                    try
                    {
                        if (control.Parent != null)
                        {
                            int num = 0;
                            do
                            {
                                try
                                {
                                    control.Parent.Controls.Remove(this._lbl[ctrlindex, num]);
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    this._lbl[ctrlindex, num] = null;
                                }
                                catch (Exception ex2)
                                {
                                }
                                num++;
                            }
                            while (num <= 8);
                            control.Parent.Controls.Remove(control);
                        }
                        try
                        {
                            if (this._textbox[ctrlindex] != null && this._textbox[ctrlindex].Parent != null)
                            {
                                this._textbox[ctrlindex].Parent.Controls.Remove(this._textbox[ctrlindex]);
                            }
                        }
                        catch (Exception ex3)
                        {
                        }
                        try
                        {
                            this.MyControl[ctrlindex].Dispose();
                        }
                        catch (Exception ex4)
                        {
                        }
                        try
                        {
                            this.MyControl[ctrlindex] = null;
                            this._textbox[ctrlindex] = null;
                            this.myselectzt[ctrlindex] = false;
                        }
                        catch (Exception ex5)
                        {
                        }
                    }
                    catch (Exception ex6)
                    {
                    }
                }
            }
        }

        // Token: 0x06000803 RID: 2051 RVA: 0x00048D1C File Offset: 0x00046F1C
        public void MyShowStatus()
        {
            int[] selectedAllControls = this.GetSelectedAllControls();
            checked
            {
                if (selectedAllControls == null)
                {
                    this.MyShowStatus(null);
                }
                else
                {
                    int num = selectedAllControls.Length;
                    if (num == 1)
                    {
                        this.MyShowStatus(this.MyControl[selectedAllControls[0]]);
                    }
                    else
                    {
                        object[] array = new object[num - 1 + 1];
                        int num2 = 0;
                        int num3 = num - 1;
                        for (int i = num2; i <= num3; i++)
                        {
                            array[i] = this.MyControl[selectedAllControls[i]];
                        }
                        this.pg.SelectedObject = null;
                        this.pg.SelectedObjects = array;
                        this.pgs.Text = "控件属性：选中多个对象";
                    }
                }
            }
        }

        // Token: 0x06000804 RID: 2052 RVA: 0x00048DA8 File Offset: 0x00046FA8
        public void MyShowStatus(Control Xcc)
        {
            if (Xcc == null)
            {
                MoveControl.ShowStatusEventHandler showStatusEvent = this.ShowStatus;
                if (showStatusEvent != null)
                {
                    showStatusEvent("", Xcc);
                }
                this.pg.SelectedObjects = null;
                this.pg.SelectedObject = null;
                this.pgs.Text = "未选择任何控件";
            }
            else
            {
                string tt = "";
                string text = Strings.Format(this.Rh.ConvertToMM(Convert.ToSingle(Math.Round(new decimal(Xcc.Left), 1)), true), "#####.##");
                string text2 = Strings.Format(this.Rh.ConvertToMM(Convert.ToSingle(Math.Round(new decimal(Xcc.Top), 1)), false), "#####.##");
                string text3 = Strings.Format(this.Rh.ConvertToMM(Convert.ToSingle(Math.Round(new decimal(Xcc.Width), 1)), true), "#####.##");
                string text4 = Strings.Format(this.Rh.ConvertToMM(Convert.ToSingle(Math.Round(new decimal(Xcc.Height), 1)), false), "#####.##");
                this.pg.SelectedObjects = null;
                if (Xcc is U_HLine)
                {
                    U_HLine u_HLine = (U_HLine)Xcc;
                    this.pg.SelectedObject = u_HLine;
                    tt = string.Concat(new string[]
                    {
                        "横线：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   长度 [",
                        text3,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_HLine.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【横线】";
                }
                else if (Xcc is U_VLine)
                {
                    U_VLine u_VLine = (U_VLine)Xcc;
                    this.pg.SelectedObject = u_VLine;
                    tt = string.Concat(new string[]
                    {
                        "竖线：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   长度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_VLine.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【竖线】";
                }
                else if (Xcc is U_Text)
                {
                    U_Text u_Text = (U_Text)Xcc;
                    this.pg.SelectedObject = u_Text;
                    tt = string.Concat(new string[]
                    {
                        "文本控件：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_Text.IsPrint, "是", "否")),
                        "]  内容 [",
                        u_Text.TextValue,
                        "]"
                    });
                    this.pgs.Text = "控件属性：【文本控件】";
                }
                else if (Xcc is U_Express)
                {
                    U_Express u_Express = (U_Express)Xcc;
                    this.pg.SelectedObject = u_Express;
                    tt = string.Concat(new string[]
                    {
                        "表达式：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_Express.IsPrint, "是", "否")),
                        "]  内容 [",
                        u_Express.TextValue,
                        "]"
                    });
                    this.pgs.Text = "控件属性：【表达式】";
                }
                else if (Xcc is U_Bar)
                {
                    U_Bar u_Bar = (U_Bar)Xcc;
                    this.pg.SelectedObject = u_Bar;
                    tt = string.Concat(new string[]
                    {
                        "条码控件：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_Bar.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【条码控件】";
                }
                else if (Xcc is U_Comput)
                {
                    U_Comput u_Comput = (U_Comput)Xcc;
                    this.pg.SelectedObject = u_Comput;
                    tt = string.Concat(new string[]
                    {
                        "计算公式：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_Comput.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【计算公式】";
                }
                else if (Xcc is U_Field)
                {
                    U_Field u_Field = (U_Field)Xcc;
                    this.pg.SelectedObject = u_Field;
                    tt = string.Concat(new string[]
                    {
                        "数据字段：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_Field.IsPrint, "是", "否")),
                        "]  字段[",
                        u_Field.TextValue,
                        "]"
                    });
                    this.pgs.Text = "控件属性：【数据字段】";
                }
                else if (Xcc is U_Image)
                {
                    U_Image u_Image = (U_Image)Xcc;
                    this.pg.SelectedObject = u_Image;
                    tt = string.Concat(new string[]
                    {
                        "图像：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_Image.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【图像】";
                }
                else if (Xcc is U_Rect)
                {
                    U_Rect u_Rect = (U_Rect)Xcc;
                    this.pg.SelectedObject = u_Rect;
                    tt = string.Concat(new string[]
                    {
                        "矩形：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_Rect.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【矩形】";
                }
                else if (Xcc is U_Bias)
                {
                    U_Bias u_Bias = (U_Bias)Xcc;
                    this.pg.SelectedObject = u_Bias;
                    tt = string.Concat(new string[]
                    {
                        "斜线：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_Bias.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【斜线】";
                }
                else if (Xcc is U_Ellipse)
                {
                    U_Ellipse u_Ellipse = (U_Ellipse)Xcc;
                    this.pg.SelectedObject = u_Ellipse;
                    tt = string.Concat(new string[]
                    {
                        "椭圆：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_Ellipse.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【椭圆】";
                }
                else if (Xcc is U_fBias)
                {
                    U_fBias u_fBias = (U_fBias)Xcc;
                    this.pg.SelectedObject = u_fBias;
                    tt = string.Concat(new string[]
                    {
                        "反斜线：X1 [",
                        text,
                        "]   Y1 [",
                        text2,
                        "]   X2 [",
                        text3,
                        "]   Y2 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_fBias.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【反斜线】";
                }
                else if (Xcc is U_QC)
                {
                    U_QC u_QC = (U_QC)Xcc;
                    this.pg.SelectedObject = u_QC;
                    tt = string.Concat(new string[]
                    {
                        "二维码：X [",
                        text,
                        "]   Y [",
                        text2,
                        "]   宽度 [",
                        text3,
                        "]   高度 [",
                        text4,
                        "]   是否套打 [",
                        Convert.ToString(Interaction.IIf(u_QC.IsPrint, "是", "否")),
                        "]"
                    });
                    this.pgs.Text = "控件属性：【二维码】";
                }
                MoveControl.ShowStatusEventHandler showStatusEvent = this.ShowStatus;
                if (showStatusEvent != null)
                {
                    showStatusEvent(tt, Xcc);
                }
            }
        }

        // Token: 0x06000805 RID: 2053 RVA: 0x0004983C File Offset: 0x00047A3C
        public void SetAllControlDefaultFont(Font ff)
        {
            checked
            {
                if (ff != null)
                {
                    int num = 0;
                    do
                    {
                        if (this.MyControl[num] != null)
                        {
                        }
                        num++;
                    }
                    while (num <= 1500);
                }
            }
        }

        // Token: 0x06000806 RID: 2054 RVA: 0x00049868 File Offset: 0x00047A68
        public void ZJRight()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件的粘接功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Left = currentSelectedControl.Left + currentSelectedControl.Width;
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的粘接功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x06000807 RID: 2055 RVA: 0x000498F8 File Offset: 0x00047AF8
        public void ZJLeft()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件的粘接功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Left = currentSelectedControl.Left - control.Width;
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的粘接功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x06000808 RID: 2056 RVA: 0x00049988 File Offset: 0x00047B88
        public void ZJTop()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件的粘接功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Top = currentSelectedControl.Top - control.Height;
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的粘接功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x06000809 RID: 2057 RVA: 0x00049A18 File Offset: 0x00047C18
        public void ZJBottom()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件的粘接功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Top = currentSelectedControl.Top + currentSelectedControl.Height;
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的粘接功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x0600080A RID: 2058 RVA: 0x00049AA8 File Offset: 0x00047CA8
        public void SizeWidth()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件的统一大小功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            if (!(control is U_VLine))
                            {
                                control.Width = currentSelectedControl.Width;
                            }
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的统一大小功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x0600080B RID: 2059 RVA: 0x00049B38 File Offset: 0x00047D38
        public void SizeHeight()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件的统一大小功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            if (!(control is U_HLine))
                            {
                                control.Height = currentSelectedControl.Height;
                            }
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的统一大小功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x0600080C RID: 2060 RVA: 0x00049BC8 File Offset: 0x00047DC8
        public void SizeAll()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件的统一大小功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            if (!(control is U_HLine))
                            {
                                control.Height = currentSelectedControl.Height;
                            }
                            if (!(control is U_VLine))
                            {
                                control.Width = currentSelectedControl.Width;
                            }
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的统一大小功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x0600080D RID: 2061 RVA: 0x00049C6C File Offset: 0x00047E6C
        public void AlignmentLeft()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件对齐功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Left = currentSelectedControl.Left;
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的统一大小功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x0600080E RID: 2062 RVA: 0x00049CF4 File Offset: 0x00047EF4
        public void AlignmentRight()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件对齐功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Left = currentSelectedControl.Width + currentSelectedControl.Left - control.Width;
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的统一大小功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x0600080F RID: 2063 RVA: 0x00049D8C File Offset: 0x00047F8C
        public void AlignmentTop()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件对齐功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Top = currentSelectedControl.Top;
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的统一大小功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x06000810 RID: 2064 RVA: 0x00049E14 File Offset: 0x00048014
        public void AlignmentBottom()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件对齐功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Top = currentSelectedControl.Top + currentSelectedControl.Height - control.Height;
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的统一大小功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x06000811 RID: 2065 RVA: 0x00049EAC File Offset: 0x000480AC
        public void AlignmentCenter()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件对齐功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Left = (int)Math.Round(unchecked((double)currentSelectedControl.Width / 2.0 + (double)currentSelectedControl.Left - (double)control.Width / 2.0));
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的统一大小功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x06000812 RID: 2066 RVA: 0x00049F68 File Offset: 0x00048168
        public void AlignmentMiddle()
        {
            int[] array = this.GetSelectedAllControls();
            checked
            {
                if (array != null && array.Length > 1)
                {
                    Control currentSelectedControl = this.GetCurrentSelectedControl();
                    if (currentSelectedControl == null)
                    {
                        Interaction.MsgBox("要使用控件对齐功能，必须选中一个控件作为基准控件（控件四周的点颜色为黑色的控件）", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        array = this.GetSelectedControls();
                        int num = 0;
                        int num2 = array.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            Control control = this.MyControl[array[i]];
                            control.Top = (int)Math.Round(unchecked((double)currentSelectedControl.Height / 2.0 + (double)currentSelectedControl.Top - (double)control.Height / 2.0));
                            this.MoveHandles(array[i]);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("要使用控件的统一大小功能，必须选中至少两个控件", MsgBoxStyle.OkOnly, "提示信息");
                }
            }
        }

        // Token: 0x06000813 RID: 2067 RVA: 0x0004A024 File Offset: 0x00048224
        public void AddControl(Control moveControl, PictureBox myparent, bool isonlyforprint = false)
        {
            checked
            {
                if (moveControl != null)
                {
                    moveControl.Parent = myparent;
                    moveControl.Cursor = Cursors.Hand;
                    Padding margin = new Padding(0);
                    moveControl.Margin = margin;
                    int newControlIndex = this.GetNewControlIndex();
                    if (newControlIndex == -1)
                    {
                        Interaction.MsgBox("不能添加新控件，超出了程序允许的最大控件个数[" + Convert.ToString(1500) + "]个", MsgBoxStyle.OkOnly, "提示信息");
                    }
                    else
                    {
                        this.MyControl[newControlIndex] = moveControl;
                        this.myselectzt[newControlIndex] = false;
                        this._MControl = moveControl;
                        if (!isonlyforprint)
                        {
                            this._MControl.MouseDown += this.Control_MouseDown;
                            this._MControl.MouseUp += this.Control_MouseUp;
                            this._MControl.MouseMove += this.Control_MouseMove;
                            this._MControl.Click += this.Control_Click;
                            this._MControl.DoubleClick += this.Control_DoubleClick;
                            this._MControl.LocationChanged += this.Control_LocationChanged;
                            this._MControl.SizeChanged += this.Control_SizeChanged;
                            int num = 0;
                            do
                            {
                                this._lbl[newControlIndex, num] = new Label();
                                this._lbl[newControlIndex, num].TabIndex = num;
                                this._lbl[newControlIndex, num].FlatStyle = FlatStyle.Flat;
                                this._lbl[newControlIndex, num].BorderStyle = BorderStyle.FixedSingle;
                                this._lbl[newControlIndex, num].BackColor = this.BOX_COLOR;
                                this._lbl[newControlIndex, num].Cursor = this._arrArrow[num];
                                this._lbl[newControlIndex, num].Visible = false;
                                this._lbl[newControlIndex, num].Text = "";
                                this._lbl[newControlIndex, num].BringToFront();
                                this._lbl[newControlIndex, num].MouseDown += this.handle_MouseDown;
                                this._lbl[newControlIndex, num].MouseMove += this.handle_MouseMove;
                                this._lbl[newControlIndex, num].MouseUp += this.handle_MouseUp;
                                num++;
                            }
                            while (num <= 7);
                            this._lbl[newControlIndex, 8] = new Label();
                            this._lbl[newControlIndex, 8].TabIndex = 8;
                            this._lbl[newControlIndex, 8].FlatStyle = FlatStyle.Flat;
                            this._lbl[newControlIndex, 8].BorderStyle = BorderStyle.FixedSingle;
                            this._lbl[newControlIndex, 8].BackColor = this.BOX_LINECOLOR;
                            this._lbl[newControlIndex, 8].Cursor = this._arrArrow[8];
                            if (moveControl is U_VLine | String.Compare(Convert.ToString(moveControl.Tag), "横线", false) == 0 | String.Compare(Convert.ToString(moveControl.Tag), "竖线", false) == 0 | String.Compare(Convert.ToString(moveControl.Tag), "矩形", false) == 0 | String.Compare(Convert.ToString(moveControl.Tag), "斜线", false) == 0 | String.Compare(Convert.ToString(moveControl.Tag), "反斜线", false) == 0)
                            {
                                this._lbl[newControlIndex, 8].Visible = false;
                            }
                            else
                            {
                                this._lbl[newControlIndex, 8].Visible = false;
                            }
                            this._lbl[newControlIndex, 8].Text = "";
                            this._lbl[newControlIndex, 8].BringToFront();
                            this._lbl[newControlIndex, 8].MouseDown += this.Center_MouseDown;
                            this._lbl[newControlIndex, 8].MouseMove += this.Center_MouseMove;
                            this._lbl[newControlIndex, 8].MouseUp += this.Center_MouseUp;
                            this._lbl[newControlIndex, 8].Click += this.Center_Click;
                            this._lbl[newControlIndex, 8].DoubleClick += this.Center_DoubleClick;
                            if (String.Compare(Convert.ToString(this._MControl.Tag), "横线", false) == 0 | this._MControl is U_HLine)
                            {
                                this._MControl.BringToFront();
                            }
                            else if (String.Compare(Convert.ToString(this._MControl.Tag), "竖线", false) == 0 | this._MControl is U_VLine)
                            {
                                this._MControl.BringToFront();
                            }
                            else if (String.Compare(Convert.ToString(this._MControl.Tag), "矩形", false) == 0 | this._MControl is U_Rect)
                            {
                                this._MControl.SendToBack();
                            }
                            else if (String.Compare(Convert.ToString(this._MControl.Tag), "斜线", false) == 0 | this._MControl is U_Bias)
                            {
                                this._MControl.SendToBack();
                            }
                            else if (String.Compare(Convert.ToString(this._MControl.Tag), "椭圆", false) == 0 | this._MControl is U_Ellipse)
                            {
                                this._MControl.SendToBack();
                            }
                            else if (String.Compare(Convert.ToString(this._MControl.Tag), "反斜线", false) == 0 | this._MControl is U_fBias)
                            {
                                this._MControl.SendToBack();
                            }
                            else
                            {
                                this._MControl.BringToFront();
                            }
                            this.CreateTextBox(newControlIndex);
                            this.Create(newControlIndex, myparent);
                            this.SetControlCurrentSelected(newControlIndex, true);
                            this.MyShowStatus(this._MControl);
                        }
                    }
                }
            }
        }

        // Token: 0x06000814 RID: 2068 RVA: 0x0004A610 File Offset: 0x00048810
        private int GetNewControlIndex()
        {
            int num = 0;
            checked
            {
                while (this.MyControl[num] != null)
                {
                    num++;
                    if (num > 1499)
                    {
                        return -1;
                    }
                }
                return num;
            }
        }

        // Token: 0x06000815 RID: 2069 RVA: 0x0004A640 File Offset: 0x00048840
        public int GetMaxControlCount()
        {
            return 1500;
        }

        // Token: 0x06000816 RID: 2070 RVA: 0x0004A654 File Offset: 0x00048854
        public Control GetControl(int index)
        {
            Control result;
            if (index > 1500 | index < 0)
            {
                result = null;
            }
            else
            {
                result = this.MyControl[index];
            }
            return result;
        }

        // Token: 0x06000817 RID: 2071 RVA: 0x0004A680 File Offset: 0x00048880
        public Control GetCurrentSelectedControl()
        {
            int num = 0;
            checked
            {
                while (this.MyControl[num] == null || this._lbl[num, 0] == null || !(this.myselectzt[num] & this._lbl[num, 0].BackColor == this.BOX_CurrentSelectedColor))
                {
                    num++;
                    if (num > 1500)
                    {
                        return null;
                    }
                }
                return this.MyControl[num];
            }
        }

        // Token: 0x06000818 RID: 2072 RVA: 0x0004A6F4 File Offset: 0x000488F4
        public int GetCurrentSelectedControlIndex()
        {
            int num = 0;
            checked
            {
                while (this.MyControl[num] == null || this._lbl[num, 0] == null || !(this.myselectzt[num] & this._lbl[num, 0].BackColor == this.BOX_CurrentSelectedColor))
                {
                    num++;
                    if (num > 1500)
                    {
                        return -1;
                    }
                }
                return num;
            }
        }

        // Token: 0x06000819 RID: 2073 RVA: 0x0004A760 File Offset: 0x00048960
        public int[] GetSelectedControls()
        {
            int[] array = null;
            int num = 0;
            int num2 = 0;
            checked
            {
                do
                {
                    if (this.MyControl[num2] != null && this._lbl[num2, 0] != null && (this.myselectzt[num2] & this._lbl[num2, 0].BackColor == this.BOX_COLOR))
                    {
                        array = (int[])Utils.CopyArray((Array)array, new int[num + 1]);
                        array[num] = num2;
                        num++;
                    }
                    num2++;
                }
                while (num2 <= 1500);
                return array;
            }
        }

        // Token: 0x0600081A RID: 2074 RVA: 0x0004A7EC File Offset: 0x000489EC
        public int[] GetSelectedAllControls()
        {
            int[] array = null;
            int num = 0;
            int num2 = 0;
            checked
            {
                do
                {
                    if (this.MyControl[num2] != null && this._lbl[num2, 0] != null && (this.myselectzt[num2] & (this._lbl[num2, 0].BackColor == this.BOX_COLOR | this._lbl[num2, 0].BackColor == this.BOX_CurrentSelectedColor)))
                    {
                        array = (int[])Utils.CopyArray((Array)array, new int[num + 1]);
                        array[num] = num2;
                        num++;
                    }
                    num2++;
                }
                while (num2 <= 1500);
                return array;
            }
        }

        // Token: 0x0600081B RID: 2075 RVA: 0x0004A8A8 File Offset: 0x00048AA8
        private int GetControlIndex(Control txt)
        {
            checked
            {
                int result;
                if (txt == null)
                {
                    result = -1;
                }
                else
                {
                    int num = 0;
                    while (this.MyControl[num] == null || this.MyControl[num] != txt)
                    {
                        num++;
                        if (num > 1500)
                        {
                            return -1;
                        }
                    }
                    result = num;
                }
                return result;
            }
        }

        // Token: 0x0600081C RID: 2076 RVA: 0x0004A8F0 File Offset: 0x00048AF0
        private int GetControlIndexByText(Label txt)
        {
            int num = 0;
            checked
            {
                while (this._lbl[num, 0] == null || !(this._lbl[num, 0] == txt | this._lbl[num, 1] == txt | this._lbl[num, 2] == txt | this._lbl[num, 3] == txt | this._lbl[num, 4] == txt | this._lbl[num, 5] == txt | this._lbl[num, 6] == txt | this._lbl[num, 7] == txt | this._lbl[num, 8] == txt))
                {
                    num++;
                    if (num > 1500)
                    {
                        return -1;
                    }
                }
                return num;
            }
        }

        // Token: 0x0600081D RID: 2077 RVA: 0x0004A9D8 File Offset: 0x00048BD8
        private int GetControlIndexByText(TextBox txt)
        {
            int num = 0;
            checked
            {
                while (this._textbox[num] == null || this._textbox[num] != txt)
                {
                    num++;
                    if (num > 1500)
                    {
                        return -1;
                    }
                }
                return num;
            }
        }

        // Token: 0x0600081E RID: 2078 RVA: 0x0004AA18 File Offset: 0x00048C18
        public void CancelAllSelected()
        {
            int num = 0;
            checked
            {
                do
                {
                    if (this.MyControl[num] != null)
                    {
                        this.myselectzt[num] = false;
                        this.HideHandles(num);
                    }
                    num++;
                }
                while (num <= 1500);
                this.MyShowStatus(null);
            }
        }

        // Token: 0x0600081F RID: 2079 RVA: 0x0004AA5C File Offset: 0x00048C5C
        public void SelectedAll()
        {
            bool flag = false;
            int num = -1;
            int num2 = 0;
            checked
            {
                do
                {
                    if (this.MyControl[num2] != null)
                    {
                        if (!flag)
                        {
                            flag = true;
                            num = num2;
                        }
                        this.myselectzt[num2] = true;
                        this.ShowHandles(num2, false);
                    }
                    num2++;
                }
                while (num2 <= 1500);
                if (num >= 0)
                {
                    this.ShowHandles(num, true);
                    this._textbox[num].Focus();
                }
                this.MyShowStatus();
            }
        }

        // Token: 0x06000820 RID: 2080 RVA: 0x0004AAC8 File Offset: 0x00048CC8
        public bool IsControlCurrentSelected(int index)
        {
            return !(index > 1500 | index < 0) && (this._lbl[index, 0] != null && (this.myselectzt[index] & this._lbl[index, 0].BackColor == this.BOX_CurrentSelectedColor));
        }

        // Token: 0x06000821 RID: 2081 RVA: 0x0004AB28 File Offset: 0x00048D28
        public bool IsControlCurrentSelected(Control cc)
        {
            bool result;
            if (cc == null)
            {
                result = false;
            }
            else
            {
                int controlIndex = this.GetControlIndex(cc);
                result = this.IsControlCurrentSelected(controlIndex);
            }
            return result;
        }

        // Token: 0x06000822 RID: 2082 RVA: 0x0004AB50 File Offset: 0x00048D50
        public bool IsControlSelected(int myindex)
        {
            return !(myindex > 1500 | myindex < 0) && (this._lbl[myindex, 0] != null && (this.myselectzt[myindex] & (this._lbl[myindex, 0].BackColor == this.BOX_CurrentSelectedColor | this._lbl[myindex, 0].BackColor == this.BOX_COLOR)));
        }

        // Token: 0x06000823 RID: 2083 RVA: 0x0004ABCC File Offset: 0x00048DCC
        public bool IsControlSelected(Control cc)
        {
            bool result;
            if (cc == null)
            {
                result = false;
            }
            else
            {
                int controlIndex = this.GetControlIndex(cc);
                result = this.IsControlSelected(controlIndex);
            }
            return result;
        }

        // Token: 0x06000824 RID: 2084 RVA: 0x00004283 File Offset: 0x00002483
        public void SetControlSelected(int index, bool isselected)
        {
            if (!(index > 1500 | index < 0))
            {
                if (isselected)
                {
                    this.myselectzt[index] = true;
                    this.ShowHandles(index, false);
                }
                else
                {
                    this.myselectzt[index] = false;
                    this.HideHandles(index);
                }
                this.MyShowStatus();
            }
        }

        // Token: 0x06000825 RID: 2085 RVA: 0x0004ABF4 File Offset: 0x00048DF4
        public void SetControlSelected(Control cc, bool isselected)
        {
            if (cc != null)
            {
                int controlIndex = this.GetControlIndex(cc);
                this.SetControlSelected(controlIndex, isselected);
            }
        }

        // Token: 0x06000826 RID: 2086 RVA: 0x0004AC14 File Offset: 0x00048E14
        public void SetControlCurrentSelected(int myindex, bool isselected)
        {
            if (!(myindex > 1500 | myindex < 0))
            {
                if (isselected)
                {
                    int currentSelectedControlIndex = this.GetCurrentSelectedControlIndex();
                    if (currentSelectedControlIndex >= 0)
                    {
                        this.ShowHandles(currentSelectedControlIndex, false);
                        this.ShowHandles(myindex, true);
                        this.myselectzt[myindex] = true;
                        this._textbox[myindex].Focus();
                    }
                    else
                    {
                        this.ShowHandles(myindex, true);
                        this.myselectzt[myindex] = true;
                        this._textbox[myindex].Focus();
                    }
                }
                else
                {
                    this.HideHandles(myindex);
                    this.myselectzt[myindex] = false;
                }
                this.MyShowStatus();
            }
        }

        // Token: 0x06000827 RID: 2087 RVA: 0x0004ACA0 File Offset: 0x00048EA0
        public void SetControlCurrentSelected(Control cc, bool isselected)
        {
            if (cc != null)
            {
                int controlIndex = this.GetControlIndex(cc);
                this.SetControlCurrentSelected(controlIndex, isselected);
            }
        }

        // Token: 0x06000828 RID: 2088 RVA: 0x0004ACC0 File Offset: 0x00048EC0
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            int controlIndexByText = this.GetControlIndexByText((TextBox)sender);
            checked
            {
                if (controlIndexByText >= 0)
                {
                    int[] selectedAllControls = this.GetSelectedAllControls();
                    if (selectedAllControls != null)
                    {
                        int num = 0;
                        int num2 = selectedAllControls.Length - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            this._MControl = this.MyControl[selectedAllControls[i]];
                            if (e.KeyValue == 37 | e.KeyValue == 38 | e.KeyValue == 39 | e.KeyValue == 40)
                            {
                                if (!this._IsShitKey)
                                {
                                    if (e.KeyValue == 37)
                                    {
                                        Control mcontrol = this._MControl;
                                        mcontrol.Left--;
                                    }
                                    if (e.KeyValue == 38)
                                    {
                                        Control mcontrol = this._MControl;
                                        mcontrol.Top--;
                                    }
                                    if (e.KeyValue == 39)
                                    {
                                        Control mcontrol = this._MControl;
                                        mcontrol.Left++;
                                    }
                                    if (e.KeyValue == 40)
                                    {
                                        Control mcontrol = this._MControl;
                                        mcontrol.Top++;
                                    }
                                }
                                else
                                {
                                    if (e.KeyValue == 37 && this._MControl.Width > 1)
                                    {
                                        Control mcontrol = this._MControl;
                                        mcontrol.Width--;
                                    }
                                    if (e.KeyValue == 38 && this._MControl.Height > 1)
                                    {
                                        Control mcontrol = this._MControl;
                                        mcontrol.Height--;
                                    }
                                    if (e.KeyValue == 39)
                                    {
                                        Control mcontrol = this._MControl;
                                        mcontrol.Width++;
                                    }
                                    if (e.KeyValue == 40)
                                    {
                                        Control mcontrol = this._MControl;
                                        mcontrol.Height++;
                                    }
                                }
                                this.CheckControlPos(this._MControl);
                                this.MoveHandles(selectedAllControls[i]);
                            }
                            if (e.KeyValue == 46)
                            {
                                int num3 = 0;
                                do
                                {
                                    this._lbl[selectedAllControls[i], num3].Parent.Controls.Remove(this._lbl[selectedAllControls[i], num3]);
                                    this._lbl[selectedAllControls[i], num3] = null;
                                    num3++;
                                }
                                while (num3 <= 8);
                                this._MControl.Parent.Controls.Remove(this._MControl);
                                this._textbox[selectedAllControls[i]].Parent.Controls.Remove(this._textbox[selectedAllControls[i]]);
                                try
                                {
                                    this.MyControl[selectedAllControls[i]].Dispose();
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    this.MyControl[selectedAllControls[i]] = null;
                                    goto IL_29B;
                                }
                                catch (Exception ex2)
                                {
                                    goto IL_29B;
                                }
                                goto IL_292;
                            IL_29B:
                                this._textbox[selectedAllControls[i]] = null;
                                this.myselectzt[selectedAllControls[i]] = false;
                            }
                        IL_292:;
                        }
                        this.MyShowStatus();
                    }
                }
            }
        }

        // Token: 0x06000829 RID: 2089 RVA: 0x0004AFA4 File Offset: 0x000491A4
        private void Center_Click(object sender, EventArgs e)
        {
            int controlIndexByText = this.GetControlIndexByText((Label)sender);
            if (controlIndexByText >= 0)
            {
                this._textbox[controlIndexByText].Focus();
                this._MControl = this.MyControl[controlIndexByText];
                if (!this._IsCtrlKey)
                {
                    if (this.IsControlSelected(this._MControl))
                    {
                        this.SetControlCurrentSelected(controlIndexByText, true);
                    }
                    else
                    {
                        this.CancelAllSelected();
                        this.SetControlCurrentSelected(controlIndexByText, true);
                    }
                }
                else
                {
                    if (this.IsControlSelected(controlIndexByText))
                    {
                        this.SetControlSelected(controlIndexByText, false);
                    }
                    else
                    {
                        this.SetControlCurrentSelected(controlIndexByText, true);
                    }
                    this.MyDrawAll(this._MControl.Parent);
                }
            }
        }

        // Token: 0x0600082A RID: 2090 RVA: 0x0004B03C File Offset: 0x0004923C
        private void Center_MouseDown(object sender, MouseEventArgs e)
        {
            int controlIndexByText = this.GetControlIndexByText((Label)sender);
            checked
            {
                if (controlIndexByText < 0)
                {
                    this.mySel = null;
                }
                else
                {
                    if (e.Button == MouseButtons.Left | e.Button == MouseButtons.Right)
                    {
                        this._IsMouseDown = true;
                    }
                    this._oPointClicked = new Point(e.X, e.Y);
                    this._MControl = this.MyControl[controlIndexByText];
                    this.mypos[controlIndexByText].X = this._MControl.Left;
                    this.mypos[controlIndexByText].Y = this._MControl.Top;
                    int num = 0;
                    do
                    {
                        this._lbl[controlIndexByText, num].BringToFront();
                        num++;
                    }
                    while (num <= 8);
                    bool iswidth = false;
                    if (e.Button == MouseButtons.Left)
                    {
                        iswidth = false;
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        iswidth = true;
                    }
                    if (this.Rh != null)
                    {
                        this.Rh.SetLabelPos((float)this._MControl.Left, this._MControl.Width, iswidth, 0f);
                        this.Rh.SetLableVisible(true);
                    }
                    if (this.Rv != null)
                    {
                        this.Rv.SetLabelPos((float)this._MControl.Top, this._MControl.Height, iswidth, this.parentcontrol.GetBaseHeight((PictureBox)this._MControl.Parent));
                        this.Rv.SetLableVisible(true);
                    }
                    this.MyShowStatus();
                    this.mypos[controlIndexByText].X = this._MControl.Left;
                    this.mypos[controlIndexByText].Y = this._MControl.Top;
                    this.mypos[controlIndexByText].Width = this._MControl.Width;
                    this.mypos[controlIndexByText].Height = this._MControl.Height;
                    this.PreRect[controlIndexByText] = new Rectangle(this.mypos[controlIndexByText].X, this.mypos[controlIndexByText].Y, this.mypos[controlIndexByText].Width, this.mypos[controlIndexByText].Height);
                    this.MyDraw(ref this.PreRect[controlIndexByText], Rectangle.Empty, this._MControl.Parent);
                }
            }
        }

        // Token: 0x0600082B RID: 2091 RVA: 0x0004B2A0 File Offset: 0x000494A0
        private void Center_MouseUp(object sender, MouseEventArgs e)
        {
            int num = this.GetControlIndexByText((Label)sender);
            checked
            {
                if (num < 0)
                {
                    this._IsMouseDown = false;
                    this.mySel = null;
                    this.MyShowStatus();
                }
                else
                {
                    if (!this.myselectzt[num])
                    {
                        this.CancelAllSelected();
                        this.SetControlCurrentSelected(num, true);
                    }
                    if (this._IsMouseDown)
                    {
                        this.MyDraw(ref this.PreRect[num], Rectangle.Empty, ((Label)sender).Parent);
                    }
                    this._MControl = this.MyControl[num];
                    if (this._IsMouseDown)
                    {
                        if (!this._IsShitKey)
                        {
                            float num2 = (float)this.mypos[num].X;
                            float num3 = (float)this.mypos[num].Y;
                            Point p = new Point((int)Math.Round((double)num2), (int)Math.Round((double)num3));
                            p = this._MControl.Parent.PointToScreen(p);
                            Point pt = this.parentcontrol.PointToClient(p);
                            PictureBox pictureBox = null;
                            Control childAtPoint = this.parentcontrol.GetChildAtPoint(pt);
                            while (childAtPoint != null)
                            {
                                if (!(childAtPoint is PictureBox))
                                {
                                    pt = childAtPoint.PointToClient(p);
                                    childAtPoint = childAtPoint.GetChildAtPoint(pt);
                                }
                                else
                                {
                                    pt = childAtPoint.PointToClient(p);
                                    pictureBox = (PictureBox)childAtPoint;
                                IL_31A:
                                    if (pictureBox != null)
                                    {
                                        if (pictureBox != this._MControl.Parent)
                                        {
                                            this.ChangeControlParent(num, pictureBox);
                                            num2 = (float)pt.X;
                                            num3 = (float)pt.Y;
                                        }
                                        this._MControl.SetBounds((int)Math.Round((double)num2), (int)Math.Round((double)num3), this._MControl.Width, this._MControl.Height);
                                        this._MControl.Refresh();
                                        this.MoveHandles(num);
                                        goto IL_391;
                                    }
                                    goto IL_391;
                                }
                            }

                        }
                        if (Math.Abs(this.mypos[num].X - this._MControl.Left) > 10 | Math.Abs(this.mypos[num].Y - this._MControl.Top) > 10)
                        {
                            float num4 = (float)this.mypos[num].X;
                            float num5 = (float)this.mypos[num].Y;
                            Point p2 = new Point((int)Math.Round((double)num4), (int)Math.Round((double)num5));
                            p2 = this._MControl.Parent.PointToScreen(p2);
                            Point pt2 = this.parentcontrol.PointToClient(p2);
                            PictureBox pictureBox2 = null;
                            Control childAtPoint2 = this.parentcontrol.GetChildAtPoint(pt2);
                            while (childAtPoint2 != null)
                            {
                                if (!(childAtPoint2 is PictureBox))
                                {
                                    pt2 = childAtPoint2.PointToClient(p2);
                                    childAtPoint2 = childAtPoint2.GetChildAtPoint(pt2);
                                }
                                else
                                {
                                    pt2 = childAtPoint2.PointToClient(p2);
                                    pictureBox2 = (PictureBox)childAtPoint2;
                                IL_187:
                                    if (pictureBox2 != null)
                                    {
                                        if (pictureBox2 != this._MControl.Parent)
                                        {
                                            num4 = (float)pt2.X;
                                            num5 = (float)pt2.Y;
                                        }
                                        this._MControl.SetBounds(this._MControl.Left, this._MControl.Top, this._MControl.Width, this._MControl.Height);
                                        this._MControl.Refresh();
                                        this.MoveHandles(num);
                                        Control control = this.CopyControl(this._MControl);
                                        control.Left = (int)Math.Round((double)num4);
                                        control.Top = (int)Math.Round((double)num5);
                                        this.AddControl(control, pictureBox2, false);
                                        this.CancelAllSelected();
                                        num = this.GetControlIndex(control);
                                        this._MControl = control;
                                        this._MControl.Refresh();
                                        goto IL_391;
                                    }
                                    goto IL_391;
                                }
                            }

                        }
                        this._MControl.Refresh();
                    }
                IL_391:
                    this._IsMouseDown = false;
                    this.mySel = null;
                    if (this.Rh != null)
                    {
                        this.Rh.SetLableVisible(false);
                    }
                    if (this.Rv != null)
                    {
                        this.Rv.SetLableVisible(false);
                    }
                    this.MyShowStatus();
                    this.SetControlCurrentSelected(num, true);
                    this.MyDrawAll(this._MControl.Parent);
                }
            }
        }

        // Token: 0x0600082C RID: 2092 RVA: 0x0004B694 File Offset: 0x00049894
        private void Center_MouseMove(object sender, MouseEventArgs e)
        {
            int controlIndexByText = this.GetControlIndexByText((Label)sender);
            checked
            {
                if (controlIndexByText >= 0)
                {
                    this._MControl = this.MyControl[controlIndexByText];
                    bool iswidth = false;
                    if (e.Button == MouseButtons.Left)
                    {
                        iswidth = false;
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        iswidth = true;
                    }
                    if (this._IsMouseDown & (e.Button == MouseButtons.Left | e.Button == MouseButtons.Right))
                    {
                        int num = this._MControl.Left + (e.X - this._oPointClicked.X);
                        int num2 = this._MControl.Top + (e.Y - this._oPointClicked.Y);
                        this.mypos[controlIndexByText].X = num;
                        this.mypos[controlIndexByText].Y = num2;
                        this.NewRect[controlIndexByText] = new Rectangle(this.mypos[controlIndexByText].X, this.mypos[controlIndexByText].Y, this._MControl.Width, this._MControl.Height);
                        this.MyDraw(ref this.PreRect[controlIndexByText], this.NewRect[controlIndexByText], ((Label)sender).Parent);
                        this.PreRect[controlIndexByText] = this.NewRect[controlIndexByText];
                        if (this.Rh != null)
                        {
                            this.Rh.SetLabelPos((float)num, this.MyControl[controlIndexByText].Width, iswidth, 0f);
                        }
                        if (this.Rv != null)
                        {
                            this.Rv.SetLabelPos((float)num2, this.MyControl[controlIndexByText].Height, iswidth, this.parentcontrol.GetBaseHeight((PictureBox)this._MControl.Parent));
                        }
                    }
                    else
                    {
                        if (this.Rh != null)
                        {
                            this.Rh.SetLabelPos((float)this.MyControl[controlIndexByText].Left, this.MyControl[controlIndexByText].Width, iswidth, 0f);
                        }
                        if (this.Rv != null)
                        {
                            this.Rv.SetLabelPos((float)this.MyControl[controlIndexByText].Top, this.MyControl[controlIndexByText].Height, iswidth, this.parentcontrol.GetBaseHeight((PictureBox)this._MControl.Parent));
                        }
                    }
                }
            }
        }

        // Token: 0x0600082D RID: 2093 RVA: 0x0004B8F0 File Offset: 0x00049AF0
        private void MyDraw(ref Rectangle sourrect, Rectangle newrect, Control myparent)
        {
            if (!sourrect.IsEmpty)
            {
                Rectangle rectangle = myparent.RectangleToScreen(sourrect);
                ControlPaint.DrawReversibleFrame(rectangle, Color.White, FrameStyle.Dashed);
                sourrect = Rectangle.Empty;
            }
            if (!newrect.IsEmpty)
            {
                Rectangle rectangle = myparent.RectangleToScreen(newrect);
                ControlPaint.DrawReversibleFrame(rectangle, Color.White, FrameStyle.Dashed);
            }
        }

        // Token: 0x0600082E RID: 2094 RVA: 0x0004B948 File Offset: 0x00049B48
        private void MyDrawAll(Control myparent)
        {
            int num = 0;
            checked
            {
                do
                {
                    this.MyDraw(ref this.PreRect[num], Rectangle.Empty, myparent);
                    num++;
                }
                while (num <= 1499);
            }
        }

        // Token: 0x0600082F RID: 2095 RVA: 0x0004B97C File Offset: 0x00049B7C
        private void Control_Click(object sender, EventArgs e)
        {
            int controlIndex = this.GetControlIndex((Control)sender);
            if (controlIndex >= 0)
            {
                this._textbox[controlIndex].Focus();
                this._MControl = this.MyControl[controlIndex];
                if (!this._IsCtrlKey)
                {
                    if (this.IsControlSelected(this._MControl))
                    {
                        this.SetControlCurrentSelected(controlIndex, true);
                    }
                    else
                    {
                        this.CancelAllSelected();
                        this.SetControlCurrentSelected(controlIndex, true);
                    }
                }
                else
                {
                    if (this.IsControlSelected(this._MControl))
                    {
                        this.SetControlSelected(controlIndex, false);
                    }
                    else
                    {
                        this.SetControlCurrentSelected(controlIndex, true);
                    }
                    this.MyDrawAll(this._MControl.Parent);
                }
            }
        }

        // Token: 0x06000830 RID: 2096 RVA: 0x0004BA18 File Offset: 0x00049C18
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            int controlIndex = this.GetControlIndex((Control)sender);
            checked
            {
                if (controlIndex < 0)
                {
                    this.mySel = null;
                }
                else
                {
                    if (e.Button == MouseButtons.Left | e.Button == MouseButtons.Right)
                    {
                        this._IsMouseDown = true;
                    }
                    this._oPointClicked = new Point(e.X, e.Y);
                    this._MControl = this.MyControl[controlIndex];
                    int num = 0;
                    do
                    {
                        this._lbl[controlIndex, num].BringToFront();
                        num++;
                    }
                    while (num <= 8);
                    bool iswidth = false;
                    if (e.Button == MouseButtons.Left)
                    {
                        iswidth = false;
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        iswidth = true;
                    }
                    if (this.Rh != null)
                    {
                        this.Rh.SetLabelPos((float)this._MControl.Left, this._MControl.Width, iswidth, 0f);
                        this.Rh.SetLableVisible(true);
                    }
                    if (this.Rv != null)
                    {
                        this.Rv.SetLabelPos((float)this._MControl.Top, this._MControl.Height, iswidth, this.parentcontrol.GetBaseHeight((PictureBox)this._MControl.Parent));
                        this.Rv.SetLableVisible(true);
                    }
                    this.MyShowStatus();
                    int num2 = 0;
                    do
                    {
                        this.mypos[num2] = Rectangle.Empty;
                        num2++;
                    }
                    while (num2 <= 1500);
                    this.mySel = this.GetSelectedAllControls();
                    if (this.mySel != null && this.myselectzt[controlIndex])
                    {
                        int num3 = 0;
                        int num4 = this.mySel.Length - 1;
                        for (int i = num3; i <= num4; i++)
                        {
                            this.mypos[this.mySel[i]].X = this.MyControl[this.mySel[i]].Left;
                            this.mypos[this.mySel[i]].Y = this.MyControl[this.mySel[i]].Top;
                            this.mypos[this.mySel[i]].Width = this.MyControl[this.mySel[i]].Width;
                            this.mypos[this.mySel[i]].Height = this.MyControl[this.mySel[i]].Height;
                            this.PreRect[this.mySel[i]] = new Rectangle(this.mypos[this.mySel[i]].X, this.mypos[this.mySel[i]].Y, this.mypos[this.mySel[i]].Width, this.mypos[this.mySel[i]].Height);
                            Rectangle empty = Rectangle.Empty;
                            this.MyDraw(ref empty, this.PreRect[this.mySel[i]], this.MyControl[this.mySel[i]].Parent);
                        }
                    }
                }
            }
        }

        // Token: 0x06000831 RID: 2097 RVA: 0x0004BD38 File Offset: 0x00049F38
        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            int controlIndex = this.GetControlIndex((Control)sender);
            checked
            {
                if (controlIndex < 0)
                {
                    this.mySel = null;
                    this.MyShowStatus();
                }
                else
                {
                    this._MControl = this.MyControl[controlIndex];
                    if (!this.myselectzt[controlIndex])
                    {
                        this.mySel = null;
                    }
                    else
                    {
                        int num = this.GetCurrentSelectedControlIndex();
                        if (this.mySel != null && this._IsMouseDown)
                        {
                            if (this._IsShitKey)
                            {
                                if (Math.Abs(this.mypos[controlIndex].X - this._MControl.Left) > 10 | Math.Abs(this.mypos[controlIndex].Y - this._MControl.Top) > 10)
                                {
                                    int num2 = 0;
                                    int num3 = this.mySel.Length - 1;
                                    int i = num2;
                                IL_311:
                                    while (i <= num3)
                                    {
                                        this.MyDraw(ref this.PreRect[this.mySel[i]], Rectangle.Empty, this.MyControl[this.mySel[i]].Parent);
                                        this._MControl = this.MyControl[this.mySel[i]];
                                        float num4 = (float)this.mypos[this.mySel[i]].X;
                                        float num5 = (float)this.mypos[this.mySel[i]].Y;
                                        Point p = new Point(this.mypos[this.mySel[i]].X, this.mypos[this.mySel[i]].Y);
                                        p = this._MControl.Parent.PointToScreen(p);
                                        Point pt = this.parentcontrol.PointToClient(p);
                                        PictureBox pictureBox = null;
                                        for (Control childAtPoint = this.parentcontrol.GetChildAtPoint(pt); childAtPoint != null; childAtPoint = childAtPoint.GetChildAtPoint(pt))
                                        {
                                            if (childAtPoint is PictureBox)
                                            {
                                                pt = childAtPoint.PointToClient(p);
                                                pictureBox = (PictureBox)childAtPoint;
                                            IL_1F8:
                                                if (pictureBox != null)
                                                {
                                                    if (pictureBox != this._MControl.Parent)
                                                    {
                                                        num4 = (float)pt.X;
                                                        num5 = (float)pt.Y;
                                                    }
                                                    Control control = this.CopyControl(this.MyControl[this.mySel[i]]);
                                                    control.Left = (int)Math.Round((double)num4);
                                                    control.Top = (int)Math.Round((double)num5);
                                                    this.AddControl(control, pictureBox, false);
                                                    controlIndex = this.GetControlIndex(control);
                                                    this._MControl = control;
                                                    this._MControl.Refresh();
                                                    this.myselectzt[controlIndex] = this.myselectzt[this.mySel[i]];
                                                    int num6 = 0;
                                                    do
                                                    {
                                                        this._lbl[controlIndex, num6].BackColor = this._lbl[this.mySel[i], num6].BackColor;
                                                        num6++;
                                                    }
                                                    while (num6 <= 8);
                                                    if (this.mySel[i] == num)
                                                    {
                                                        this.ShowHandles(controlIndex, false);
                                                        num = controlIndex;
                                                    }
                                                    this.CheckControlPos(control);
                                                    this.SetControlSelected(this.mySel[i], false);
                                                    this.MyControl[this.mySel[i]].Refresh();
                                                }
                                                i++;
                                                goto IL_311;
                                            }
                                            pt = childAtPoint.PointToClient(p);
                                        }

                                    }
                                    if (num >= 0)
                                    {
                                        this.ShowHandles(num, true);
                                    }
                                }
                                else
                                {
                                    int num7 = 0;
                                    int num8 = this.mySel.Length - 1;
                                    for (int j = num7; j <= num8; j++)
                                    {
                                        this.MyDraw(ref this.PreRect[this.mySel[j]], Rectangle.Empty, this.MyControl[this.mySel[j]].Parent);
                                        this._MControl.Refresh();
                                    }
                                }
                            }
                            else
                            {
                                int num9 = 0;
                                int num10 = this.mySel.Length - 1;
                                for (int k = num9; k <= num10; k++)
                                {
                                    if (!this.mypos[this.mySel[k]].IsEmpty)
                                    {
                                        this.MyDraw(ref this.PreRect[this.mySel[k]], Rectangle.Empty, this.MyControl[this.mySel[k]].Parent);
                                        this._MControl = this.MyControl[this.mySel[k]];
                                        float num11 = (float)this.mypos[this.mySel[k]].X;
                                        float num12 = (float)this.mypos[this.mySel[k]].Y;
                                        Point p2 = new Point(this.mypos[this.mySel[k]].X, this.mypos[this.mySel[k]].Y);
                                        p2 = this._MControl.Parent.PointToScreen(p2);
                                        Point pt2 = this.parentcontrol.PointToClient(p2);
                                        PictureBox pictureBox2 = null;
                                        Control childAtPoint2 = this.parentcontrol.GetChildAtPoint(pt2);
                                        while (childAtPoint2 != null)
                                        {
                                            if (!(childAtPoint2 is PictureBox))
                                            {
                                                pt2 = childAtPoint2.PointToClient(p2);
                                                childAtPoint2 = childAtPoint2.GetChildAtPoint(pt2);
                                            }
                                            else
                                            {
                                                pt2 = childAtPoint2.PointToClient(p2);
                                                pictureBox2 = (PictureBox)childAtPoint2;
                                            IL_4EB:
                                                if (pictureBox2 != null)
                                                {
                                                    if (pictureBox2 != this._MControl.Parent)
                                                    {
                                                        this.ChangeControlParent(this.mySel[k], pictureBox2);
                                                        num11 = (float)pt2.X;
                                                        num12 = (float)pt2.Y;
                                                    }
                                                    if (num11 < 0f)
                                                    {
                                                        num11 = 0f;
                                                    }
                                                    if (unchecked(num11 + (float)this._MControl.Width) > (float)this._MControl.Parent.Width)
                                                    {
                                                        num11 = (float)(this._MControl.Parent.Width - this._MControl.Width);
                                                    }
                                                    if (num12 < 0f)
                                                    {
                                                        num12 = 0f;
                                                    }
                                                    if (unchecked(num12 + (float)this._MControl.Height) > (float)this._MControl.Parent.Height)
                                                    {
                                                        num12 = (float)(this._MControl.Parent.Height - this._MControl.Height);
                                                    }
                                                    this._MControl.SetBounds((int)Math.Round((double)num11), (int)Math.Round((double)num12), this._MControl.Width, this._MControl.Height);
                                                    this._MControl.Refresh();
                                                    this.MoveHandles(this.mySel[k]);
                                                    goto IL_617;
                                                }
                                                goto IL_617;
                                            }
                                        }

                                    }
                                IL_617:;
                                }
                            }
                        }
                        this.mySel = null;
                        this._IsMouseDown = false;
                        if (this.Rh != null)
                        {
                            this.Rh.SetLableVisible(false);
                        }
                        if (this.Rv != null)
                        {
                            this.Rv.SetLableVisible(false);
                        }
                        this.MyShowStatus();
                        this.MyDrawAll(this._MControl.Parent);
                    }
                }
            }
        }

        // Token: 0x06000832 RID: 2098 RVA: 0x0004C3B8 File Offset: 0x0004A5B8
        private void CheckControlPos(Control cc)
        {
            Control parent = cc.Parent;
            bool flag = this.ishandlemousedown;
            this.ishandlemousedown = true;
            if (cc.Left < 0)
            {
                cc.Left = 0;
            }
            if (cc.Top < 0)
            {
                cc.Top = 0;
            }
            checked
            {
                if (cc.Left + cc.Width > parent.Width)
                {
                    cc.Left = parent.Width - cc.Width;
                }
                if (cc.Top + cc.Height > parent.Height)
                {
                    cc.Top = parent.Height - cc.Height;
                }
                this.ishandlemousedown = flag;
            }
        }

        // Token: 0x06000833 RID: 2099 RVA: 0x0004C454 File Offset: 0x0004A654
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            int controlIndex = this.GetControlIndex((Control)sender);
            checked
            {
                if (controlIndex >= 0 && this.mySel != null)
                {
                    int num = -1;
                    int num2 = -1;
                    if (this._IsMouseDown & (e.Button == MouseButtons.Left | e.Button == MouseButtons.Right))
                    {
                        this.mySel = this.GetSelectedAllControls();
                        int[] array = this.mySel;
                        if (array == null || !this.myselectzt[controlIndex])
                        {
                            return;
                        }
                        int num3 = 0;
                        int num4 = array.Length - 1;
                        for (int i = num3; i <= num4; i++)
                        {
                            this._MControl = this.MyControl[array[i]];
                            int num5 = this._MControl.Left + (e.X - this._oPointClicked.X);
                            int num6 = this._MControl.Top + (e.Y - this._oPointClicked.Y);
                            this.mypos[array[i]].X = num5;
                            this.mypos[array[i]].Y = num6;
                            if (array[i] == controlIndex)
                            {
                                num = num5;
                                num2 = num6;
                            }
                            this.NewRect[array[i]] = new Rectangle(this.mypos[array[i]].X, this.mypos[array[i]].Y, this._MControl.Width, this._MControl.Height);
                            this.MyDraw(ref this.PreRect[array[i]], this.NewRect[array[i]], this._MControl.Parent);
                            this.PreRect[array[i]] = this.NewRect[array[i]];
                        }
                    }
                    bool iswidth = false;
                    if (e.Button == MouseButtons.Left)
                    {
                        iswidth = false;
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        iswidth = true;
                    }
                    if (num == -1)
                    {
                        num = this.MyControl[controlIndex].Left;
                        num2 = this.MyControl[controlIndex].Top;
                    }
                    if (this.Rh != null)
                    {
                        this.Rh.SetLabelPos((float)num, this.MyControl[controlIndex].Width, iswidth, 0f);
                    }
                    if (this.Rv != null)
                    {
                        this.Rv.SetLabelPos((float)num2, this.MyControl[controlIndex].Height, iswidth, this.parentcontrol.GetBaseHeight((PictureBox)this._MControl.Parent));
                    }
                    string text = "X位置：〖" + Strings.Format(this.Rh.ConvertToMM(Convert.ToSingle(Math.Round(new decimal(num), 1)), true), "#####.#") + "〗";
                    text = text + "  Y位置：〖" + Strings.Format(this.Rh.ConvertToMM(Convert.ToSingle(Math.Round(new decimal(num2), 1)), false), "#####.#") + "〗";
                    MoveControl.ShowStatusEventHandler showStatusEvent = this.ShowStatus;
                    if (showStatusEvent != null)
                    {
                        showStatusEvent(text, null);
                    }
                }
            }
        }

        // Token: 0x06000834 RID: 2100 RVA: 0x0004C770 File Offset: 0x0004A970
        private void handle_MouseDown(object sender, MouseEventArgs e)
        {
            int controlIndexByText = this.GetControlIndexByText((Label)sender);
            if (controlIndexByText >= 0)
            {
                this._MControl = this.MyControl[controlIndexByText];
                this._dragging = true;
                this._startl = this._MControl.Left;
                this._startt = this._MControl.Top;
                this._startw = this._MControl.Width;
                this._starth = this._MControl.Height;
                this._oPointClicked = new Point(e.X, e.Y);
                this.ishandlemousedown = true;
                this.source_x = e.X;
                this.source_y = e.Y;
                if (this.Rh != null)
                {
                    this.Rh.SetLabelPos((float)this._MControl.Left, this._MControl.Width, true, 0f);
                    this.Rh.SetLableVisible(true);
                }
                if (this.Rv != null)
                {
                    this.Rv.SetLabelPos((float)this._MControl.Top, this._MControl.Height, true, this.parentcontrol.GetBaseHeight((PictureBox)this._MControl.Parent));
                    this.Rv.SetLableVisible(true);
                }
                this.MyShowStatus();
            }
        }

        // Token: 0x06000835 RID: 2101 RVA: 0x0004C8B4 File Offset: 0x0004AAB4
        private void handle_MouseMove(object sender, MouseEventArgs e)
        {
            int controlIndexByText = this.GetControlIndexByText((Label)sender);
            checked
            {
                if (controlIndexByText >= 0)
                {
                    this._MControl = this.MyControl[controlIndexByText];
                    if (e.Button == MouseButtons.Left & String.Compare(Convert.ToString(this._MControl.Tag), "横线", false) == 0 & ((Label)sender).BackColor == this.BOX_LINECOLOR)
                    {
                        int left = this._MControl.Left + (e.X - this._oPointClicked.X);
                        int top = this._MControl.Top + (e.Y - this._oPointClicked.Y);
                        this._MControl.Left = left;
                        this._MControl.Top = top;
                        this.MoveHandles(controlIndexByText);
                        if (this.Rh != null)
                        {
                            this.Rh.SetLabelPos((float)this.MyControl[controlIndexByText].Left, this.MyControl[controlIndexByText].Width, false, 0f);
                            this.Rh.SetLableVisible(true);
                        }
                        if (this.Rv != null)
                        {
                            this.Rv.SetLabelPos((float)this.MyControl[controlIndexByText].Top, this.MyControl[controlIndexByText].Height, false, this.parentcontrol.GetBaseHeight((PictureBox)this._MControl.Parent));
                            this.Rv.SetLableVisible(true);
                        }
                    }
                    else if (e.Button == MouseButtons.Left & String.Compare(Convert.ToString(this._MControl.Tag), "竖线", false) == 0 & ((Label)sender).BackColor == this.BOX_LINECOLOR)
                    {
                        int left2 = this._MControl.Left + (e.X - this._oPointClicked.X);
                        int top2 = this._MControl.Top + (e.Y - this._oPointClicked.Y);
                        this._MControl.Left = left2;
                        this._MControl.Top = top2;
                        this.MoveHandles(controlIndexByText);
                        if (this.Rh != null)
                        {
                            this.Rh.SetLabelPos((float)this.MyControl[controlIndexByText].Left, this.MyControl[controlIndexByText].Width, false, 0f);
                            this.Rh.SetLableVisible(true);
                        }
                        if (this.Rv != null)
                        {
                            this.Rv.SetLabelPos((float)this.MyControl[controlIndexByText].Top, this.MyControl[controlIndexByText].Height, false, this.parentcontrol.GetBaseHeight((PictureBox)this._MControl.Parent));
                            this.Rv.SetLableVisible(true);
                        }
                    }
                    else
                    {
                        int num = e.X - this.source_x;
                        int num2 = e.Y - this.source_y;
                        int num3 = this._MControl.Left;
                        int width = this._MControl.Width;
                        int num4 = this._MControl.Top;
                        int height = this._MControl.Height;
                        try
                        {
                            Application.DoEvents();
                        }
                        catch (Exception ex)
                        {
                        }
                        if (this._dragging)
                        {
                            switch (((Label)sender).TabIndex)
                            {
                                case 0:
                                    num3 = Convert.ToInt32(Interaction.IIf(this._startl + num < this._startl + this._startw - 8, this._startl + num, this._startl + this._startw - 8));
                                    num4 = Convert.ToInt32(Interaction.IIf(this._startt + num2 < this._startt + this._starth - 8, this._startt + num2, this._startt + this._starth - 8));
                                    width = this._startl + this._startw - this._MControl.Left;
                                    height = this._startt + this._starth - this._MControl.Top;
                                    break;
                                case 1:
                                    num4 = Convert.ToInt32(Interaction.IIf(this._startt + num2 < this._startt + this._starth - 8, this._startt + num2, this._startt + this._starth - 8));
                                    height = this._startt + this._starth - this._MControl.Top;
                                    break;
                                case 2:
                                    width = Convert.ToInt32(Interaction.IIf(this._startw + num > 8, this._startw + num, 8));
                                    num4 = Convert.ToInt32(Interaction.IIf(this._startt + num2 < this._startt + this._starth - 8, this._startt + num2, this._startt + this._starth - 8));
                                    height = this._startt + this._starth - this._MControl.Top;
                                    break;
                                case 3:
                                    width = Convert.ToInt32(Interaction.IIf(this._startw + num > 8, this._startw + num, 8));
                                    break;
                                case 4:
                                    width = Convert.ToInt32(Interaction.IIf(this._startw + num > 8, this._startw + num, 8));
                                    height = Convert.ToInt32(Interaction.IIf(this._starth + num2 > 8, this._starth + num2, 8));
                                    break;
                                case 5:
                                    height = Convert.ToInt32(Interaction.IIf(this._starth + num2 > 8, this._starth + num2, 8));
                                    break;
                                case 6:
                                    num3 = Convert.ToInt32(Interaction.IIf(this._startl + num < this._startl + this._startw - 8, this._startl + num, this._startl + this._startw - 8));
                                    width = this._startl + this._startw - this._MControl.Left;
                                    height = Convert.ToInt32(Interaction.IIf(this._starth + num2 > 8, this._starth + num2, 8));
                                    break;
                                case 7:
                                    num3 = Convert.ToInt32(Interaction.IIf(this._startl + num < this._startl + this._startw - 8, this._startl + num, this._startl + this._startw - 8));
                                    width = this._startl + this._startw - this._MControl.Left;
                                    break;
                            }
                            num3 = Convert.ToInt32(Interaction.IIf(num3 < 0, 0, num3));
                            num4 = Convert.ToInt32(Interaction.IIf(num4 < 0, 0, num4));
                            this._MControl.SetBounds(num3, num4, width, height);
                            if (this.Rh != null)
                            {
                                this.Rh.SetLabelPos((float)this.MyControl[controlIndexByText].Left, this.MyControl[controlIndexByText].Width, true, 0f);
                                this.Rh.SetLableVisible(true);
                            }
                            if (this.Rv != null)
                            {
                                this.Rv.SetLabelPos((float)this.MyControl[controlIndexByText].Top, this.MyControl[controlIndexByText].Height, true, this.parentcontrol.GetBaseHeight((PictureBox)this._MControl.Parent));
                                this.Rv.SetLableVisible(true);
                            }
                        }
                    }
                    if (e.Button == MouseButtons.Left)
                    {
                        this.MyShowStatus();
                    }
                }
            }
        }

        // Token: 0x06000836 RID: 2102 RVA: 0x0004D094 File Offset: 0x0004B294
        private void handle_MouseUp(object sender, MouseEventArgs e)
        {
            this.ishandlemousedown = false;
            int controlIndexByText = this.GetControlIndexByText((Label)sender);
            if (controlIndexByText >= 0)
            {
                this._MControl = this.MyControl[controlIndexByText];
                this._dragging = false;
                this.MoveHandles(controlIndexByText);
                if (this.IsControlCurrentSelected(this.MyControl[controlIndexByText]))
                {
                    this.ShowHandles(controlIndexByText, true);
                }
                else
                {
                    this.ShowHandles(controlIndexByText, false);
                }
                if (this.Rh != null)
                {
                    this.Rh.SetLableVisible(false);
                }
                if (this.Rv != null)
                {
                    this.Rv.SetLableVisible(false);
                }
                this.MyShowStatus();
            }
        }

        // Token: 0x06000837 RID: 2103 RVA: 0x0004D128 File Offset: 0x0004B328
        private void Center_DoubleClick(object sender, EventArgs e)
        {
            int controlIndexByText = this.GetControlIndexByText((Label)sender);
            if (controlIndexByText >= 0)
            {
                this.Control_DoubleClick(this.MyControl[controlIndexByText], e);
            }
        }

        // Token: 0x06000838 RID: 2104 RVA: 0x00002590 File Offset: 0x00000790
        private void Control_DoubleClick(object sender, EventArgs e)
        {
        }

        // Token: 0x06000839 RID: 2105 RVA: 0x0004D158 File Offset: 0x0004B358
        private void ChangeControlParent(int theindex, PictureBox newparent)
        {
            checked
            {
                try
                {
                    if (this.MyControl[theindex] != null)
                    {
                        this.MyControl[theindex].Parent = newparent;
                        int num = 0;
                        do
                        {
                            this._lbl[theindex, num].Parent = newparent;
                            num++;
                        }
                        while (num <= 8);
                        this._textbox[theindex].Parent = newparent;
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        // Token: 0x0600083A RID: 2106 RVA: 0x0004D1CC File Offset: 0x0004B3CC
        private void Create(int theindex, PictureBox myparent)
        {
            int num = 0;
            checked
            {
                do
                {
                    myparent.Controls.Add(this._lbl[theindex, num]);
                    this._lbl[theindex, num].BringToFront();
                    num++;
                }
                while (num <= 8);
                this.myselectzt[theindex] = false;
                this.HideHandles(theindex);
            }
        }

        // Token: 0x0600083B RID: 2107 RVA: 0x0004D220 File Offset: 0x0004B420
        private void CreateTextBox(int theindex)
        {
            if (this._textbox[theindex] != null)
            {
                this._textbox[theindex] = null;
            }
            this._textbox[theindex] = new TextBox();
            this._textbox[theindex].CreateControl();
            this._textbox[theindex].Parent = this._MControl.Parent;
            this._textbox[theindex].Width = 0;
            this._textbox[theindex].Height = 0;
            this._textbox[theindex].TabStop = true;
            this._textbox[theindex].KeyDown += this.textBox_KeyDown;
        }

        // Token: 0x0600083C RID: 2108 RVA: 0x0004D2B8 File Offset: 0x0004B4B8
        private void HideHandles(int theindex)
        {
            checked
            {
                if (!(theindex > 1500 | theindex < 0))
                {
                    int num = 0;
                    do
                    {
                        if (this._lbl[theindex, num] != null)
                        {
                            this._lbl[theindex, num].Visible = false;
                        }
                        num++;
                    }
                    while (num <= 7);
                    if (String.Compare(Convert.ToString(this.MyControl[theindex].Tag), "横线", false) == 0 | String.Compare(Convert.ToString(this.MyControl[theindex].Tag), "竖线", false) == 0 | String.Compare(Convert.ToString(this.MyControl[theindex].Tag), "矩形", false) == 0)
                    {
                        if (this._lbl[theindex, 8] != null)
                        {
                            this._lbl[theindex, 8].Visible = false;
                        }
                    }
                    else if (this._lbl[theindex, 8] != null)
                    {
                        this._lbl[theindex, 8].Visible = false;
                    }
                }
            }
        }

        // Token: 0x0600083D RID: 2109 RVA: 0x0004D3B8 File Offset: 0x0004B5B8
        private void MoveHandles(int theindex)
        {
            checked
            {
                if (!(theindex > 1500 | theindex < 0))
                {
                    this._MControl = this.MyControl[theindex];
                    if (this._MControl != null)
                    {
                        int num = this._MControl.Left - 5;
                        int num2 = this._MControl.Top - 5;
                        int num3 = this._MControl.Width + 5;
                        int num4 = this._MControl.Height + 5;
                        int[] array = new int[]
                        {
                            num + 2 + 2,
                            (int)Math.Round(unchecked((double)num + (double)num3 / 2.0)),
                            num + num3 - 2 - 2,
                            num + num3 - 2 - 2,
                            num + num3 - 2 - 2,
                            (int)Math.Round(unchecked((double)num + (double)num3 / 2.0)),
                            num + 2 + 2,
                            num + 2 + 2
                        };
                        int[] array2 = new int[]
                        {
                            num2 + 2 + 2,
                            num2 + 2 + 2,
                            num2 + 2 + 2,
                            (int)Math.Round(unchecked((double)num2 + (double)num4 / 2.0)),
                            num2 + num4 - 2 - 2,
                            num2 + num4 - 2 - 2,
                            num2 + num4 - 2 - 2,
                            (int)Math.Round(unchecked((double)num2 + (double)num4 / 2.0))
                        };
                        int num5 = 0;
                        do
                        {
                            this._lbl[theindex, num5].SetBounds(array[num5], array2[num5], 5, 5);
                            this._lbl[theindex, num5].BringToFront();
                            num5++;
                        }
                        while (num5 <= 7);
                        this._lbl[theindex, 8].SetBounds(array[1], array2[3], 5, 5);
                        this._lbl[theindex, 8].BringToFront();
                    }
                }
            }
        }

        // Token: 0x0600083E RID: 2110 RVA: 0x0004D59C File Offset: 0x0004B79C
        private void ShowHandles(int theindex, bool isCurrentSelected)
        {
            checked
            {
                if (!(theindex > 1500 | theindex < 0))
                {
                    this.MoveHandles(theindex);
                    this._MControl = this.MyControl[theindex];
                    if (this._MControl != null)
                    {
                        int num = 0;
                        do
                        {
                            this._lbl[theindex, num].BringToFront();
                            if (String.Compare(Convert.ToString(this._MControl.Tag), "横线", false) == 0)
                            {
                                if (num == 3 | num == 7)
                                {
                                    this._lbl[theindex, num].Visible = true;
                                }
                                else
                                {
                                    this._lbl[theindex, num].Visible = false;
                                }
                            }
                            else if (String.Compare(Convert.ToString(this._MControl.Tag), "竖线", false) == 0)
                            {
                                if (num == 1 | num == 5)
                                {
                                    this._lbl[theindex, num].Visible = true;
                                }
                                else
                                {
                                    this._lbl[theindex, num].Visible = false;
                                }
                            }
                            else if (String.Compare(Convert.ToString(this._MControl.Tag), "斜线", false) == 0)
                            {
                                if (num == 0 | num == 4)
                                {
                                    this._lbl[theindex, num].Visible = true;
                                }
                                else
                                {
                                    this._lbl[theindex, num].Visible = false;
                                }
                            }
                            else if (String.Compare(Convert.ToString(this._MControl.Tag), "反斜线", false) == 0)
                            {
                                if (num == 2 | num == 6)
                                {
                                    this._lbl[theindex, num].Visible = true;
                                }
                                else
                                {
                                    this._lbl[theindex, num].Visible = false;
                                }
                            }
                            else
                            {
                                this._lbl[theindex, num].Visible = true;
                            }
                            if (isCurrentSelected)
                            {
                                this._lbl[theindex, num].BackColor = this.BOX_CurrentSelectedColor;
                            }
                            else
                            {
                                this._lbl[theindex, num].BackColor = this.BOX_COLOR;
                            }
                            num++;
                        }
                        while (num <= 7);
                        this._lbl[theindex, 8].BringToFront();
                        this._lbl[theindex, 8].Visible = true;
                    }
                }
            }
        }

        // Token: 0x0600083F RID: 2111 RVA: 0x0004D7C4 File Offset: 0x0004B9C4
        public Control CopyControl(Control ss)
        {
            Control result = null;
            if (ss is U_HLine)
            {
                result = this.CopyControl((U_HLine)ss);
            }
            else if (ss is U_VLine)
            {
                result = this.CopyControl((U_VLine)ss);
            }
            else if (ss is U_Rect)
            {
                result = this.CopyControl((U_Rect)ss);
            }
            else if (ss is U_Image)
            {
                result = this.CopyControl((U_Image)ss);
            }
            else if (ss is U_Text)
            {
                result = this.CopyControl((U_Text)ss);
            }
            else if (ss is U_Field)
            {
                result = this.CopyControl((U_Field)ss);
            }
            else if (ss is U_Comput)
            {
                result = this.CopyControl((U_Comput)ss);
            }
            else if (ss is U_Bar)
            {
                result = this.CopyControl((U_Bar)ss);
            }
            else if (ss is U_Bias)
            {
                result = this.CopyControl((U_Bias)ss);
            }
            else if (ss is U_Express)
            {
                result = this.CopyControl((U_Express)ss);
            }
            else if (ss is U_Ellipse)
            {
                result = this.CopyControl((U_Ellipse)ss);
            }
            else if (ss is U_fBias)
            {
                result = this.CopyControl((U_fBias)ss);
            }
            else if (ss is U_QC)
            {
                result = this.CopyControl((U_QC)ss);
            }
            return result;
        }

        // Token: 0x06000840 RID: 2112 RVA: 0x0004D914 File Offset: 0x0004BB14
        public U_HLine CopyControl(U_HLine ss)
        {
            U_HLine u_HLine = new U_HLine();
            u_HLine = u_HLine;
            u_HLine.IsPrint = ss.IsPrint;
            u_HLine.X = ss.X;
            u_HLine.Y = ss.Y;
            u_HLine.EWidth = ss.EWidth;
            u_HLine.LineWidth = ss.LineWidth;
            u_HLine.LineColor = ss.LineColor;
            u_HLine.Tag = RuntimeHelpers.GetObjectValue(ss.Tag);
            return u_HLine;
        }

        // Token: 0x06000841 RID: 2113 RVA: 0x0004D988 File Offset: 0x0004BB88
        public U_VLine CopyControl(U_VLine ss)
        {
            return new U_VLine
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x06000842 RID: 2114 RVA: 0x0004D9F8 File Offset: 0x0004BBF8
        public U_Rect CopyControl(U_Rect ss)
        {
            return new U_Rect
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                FilledColor = ss.FilledColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x06000843 RID: 2115 RVA: 0x0004DA80 File Offset: 0x0004BC80
        public U_Ellipse CopyControl(U_Ellipse ss)
        {
            return new U_Ellipse
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                FilledColor = ss.FilledColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x06000844 RID: 2116 RVA: 0x0004DB08 File Offset: 0x0004BD08
        public U_Bias CopyControl(U_Bias ss)
        {
            return new U_Bias
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x06000845 RID: 2117 RVA: 0x0004DB84 File Offset: 0x0004BD84
        public U_fBias CopyControl(U_fBias ss)
        {
            return new U_fBias
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x06000846 RID: 2118 RVA: 0x0004DC00 File Offset: 0x0004BE00
        public U_Image CopyControl(U_Image ss)
        {
            return new U_Image
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                LeftBorder = ss.LeftBorder,
                TopBorder = ss.TopBorder,
                RightBorder = ss.RightBorder,
                BottomBorder = ss.BottomBorder,
                Img = ss.Img,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x06000847 RID: 2119 RVA: 0x0004DCB8 File Offset: 0x0004BEB8
        public U_Text CopyControl(U_Text ss)
        {
            return new U_Text
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                FilledColor = ss.FilledColor,
                TextAlign = ss.TextAlign,
                TextValue = ss.TextValue,
                TextFont = (Font)ss.TextFont.Clone(),
                TextColor = ss.TextColor,
                Cols = ss.Cols,
                Mulline = ss.Mulline,
                LeftBorder = ss.LeftBorder,
                TopBorder = ss.TopBorder,
                RightBorder = ss.RightBorder,
                BottomBorder = ss.BottomBorder,
                Margins = (Margins)ss.Margins.Clone(),
                Direction = ss.Direction,
                IsTdBorder = ss.IsTdBorder,
                IsTdBackColor = ss.IsTdBackColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x06000848 RID: 2120 RVA: 0x0004DDFC File Offset: 0x0004BFFC
        public U_Express CopyControl(U_Express ss)
        {
            return new U_Express
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                FilledColor = ss.FilledColor,
                TextAlign = ss.TextAlign,
                TextValue = ss.TextValue,
                TextFont = (Font)ss.TextFont.Clone(),
                TextColor = ss.TextColor,
                Cols = ss.Cols,
                Mulline = ss.Mulline,
                LeftBorder = ss.LeftBorder,
                TopBorder = ss.TopBorder,
                RightBorder = ss.RightBorder,
                BottomBorder = ss.BottomBorder,
                Margins = (Margins)ss.Margins.Clone(),
                Direction = ss.Direction,
                IsTdBorder = ss.IsTdBorder,
                IsTdBackColor = ss.IsTdBackColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x06000849 RID: 2121 RVA: 0x0004DF40 File Offset: 0x0004C140
        public U_Bar CopyControl(U_Bar ss)
        {
            return new U_Bar
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                FilledColor = ss.FilledColor,
                TextValue = ss.TextValue,
                BarType = ss.BarType,
                LeftBorder = ss.LeftBorder,
                TopBorder = ss.TopBorder,
                RightBorder = ss.RightBorder,
                BottomBorder = ss.BottomBorder,
                Margins = (Margins)ss.Margins.Clone(),
                TextFont = (Font)ss.TextFont.Clone(),
                TextColor = ss.TextColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x0600084A RID: 2122 RVA: 0x0004E048 File Offset: 0x0004C248
        public U_QC CopyControl(U_QC ss)
        {
            return new U_QC
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                FilledColor = ss.FilledColor,
                TextValue = ss.TextValue,
                BarType = ss.BarType,
                LeftBorder = ss.LeftBorder,
                TopBorder = ss.TopBorder,
                RightBorder = ss.RightBorder,
                BottomBorder = ss.BottomBorder,
                Margins = ss.Margins,
                TextFont = (Font)ss.TextFont.Clone(),
                TextColor = ss.TextColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag),
                CharType = ss.CharType
            };
        }

        // Token: 0x0600084B RID: 2123 RVA: 0x0004E154 File Offset: 0x0004C354
        public U_Field CopyControl(U_Field ss)
        {
            return new U_Field
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                FilledColor = ss.FilledColor,
                TextAlign = ss.TextAlign,
                TextValue = ss.TextValue,
                TextFont = (Font)ss.TextFont.Clone(),
                TextColor = ss.TextColor,
                Cols = ss.Cols,
                Mulline = ss.Mulline,
                LeftBorder = ss.LeftBorder,
                TopBorder = ss.TopBorder,
                RightBorder = ss.RightBorder,
                BottomBorder = ss.BottomBorder,
                Margins = (Margins)ss.Margins.Clone(),
                BeforeText = ss.BeforeText,
                Format = ss.Format,
                Direction = ss.Direction,
                IsTdBorder = ss.IsTdBorder,
                IsTdBackColor = ss.IsTdBackColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x0600084C RID: 2124 RVA: 0x0004E2B0 File Offset: 0x0004C4B0
        public U_Comput CopyControl(U_Comput ss)
        {
            return new U_Comput
            {
                IsPrint = ss.IsPrint,
                X = ss.X,
                Y = ss.Y,
                EWidth = ss.EWidth,
                EHeight = ss.EHeight,
                LineWidth = ss.LineWidth,
                LineColor = ss.LineColor,
                FilledColor = ss.FilledColor,
                TextAlign = ss.TextAlign,
                TextValue = ss.TextValue,
                TextType = ss.TextType,
                TextFont = (Font)ss.TextFont.Clone(),
                TextColor = ss.TextColor,
                Cols = ss.Cols,
                Mulline = ss.Mulline,
                LeftBorder = ss.LeftBorder,
                TopBorder = ss.TopBorder,
                RightBorder = ss.RightBorder,
                BottomBorder = ss.BottomBorder,
                Margins = (Margins)ss.Margins.Clone(),
                BeforeText = ss.BeforeText,
                Format = ss.Format,
                Direction = ss.Direction,
                IsTdBorder = ss.IsTdBorder,
                IsTdBackColor = ss.IsTdBackColor,
                Tag = RuntimeHelpers.GetObjectValue(ss.Tag)
            };
        }

        // Token: 0x0600084D RID: 2125 RVA: 0x0004E418 File Offset: 0x0004C618
        protected virtual void Dispose(bool disposing)
        {
            checked
            {
                if (!this.disposedValue)
                {
                    if (!disposing)
                    {
                    }
                    int num = 0;
                    do
                    {
                        this.DeleteControl(num);
                        num++;
                    }
                    while (num <= 1500);
                    try
                    {
                        this.Rh.Dispose();
                        this.Rv.Dispose();
                        this._textbox = null;
                        this.mySel = null;
                        this._lbl = null;
                        this.myselectzt = null;
                        this._arrArrow = null;
                        this.MyControl = null;
                        this.NewRect = null;
                        this.PreRect = null;
                        this.mypos = null;
                    }
                    catch (Exception ex)
                    {
                    }
                    GC.Collect();
                }
                this.disposedValue = true;
            }
        }

        // Token: 0x0600084E RID: 2126 RVA: 0x000042C0 File Offset: 0x000024C0
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Token: 0x04000475 RID: 1141
        public bool _IsShitKey;

        // Token: 0x04000476 RID: 1142
        private const int MIN_SIZE = 8;

        // Token: 0x04000477 RID: 1143
        private const int BOX_SIZE = 5;

        // Token: 0x04000478 RID: 1144
        public bool _IsCtrlKey;

        // Token: 0x04000479 RID: 1145
        public Ruler Rh;

        // Token: 0x0400047A RID: 1146
        public Ruler Rv;

        // Token: 0x0400047B RID: 1147
        private const int MaxControls = 1500;

        // Token: 0x0400047C RID: 1148
        private TextBox[] _textbox;

        // Token: 0x0400047D RID: 1149
        private Control _MControl;

        // Token: 0x0400047E RID: 1150
        private bool _IsMouseDown;

        // Token: 0x0400047F RID: 1151
        private Point _oPointClicked;

        // Token: 0x04000480 RID: 1152
        private Color BOX_COLOR;

        // Token: 0x04000481 RID: 1153
        private Color BOX_CurrentSelectedColor;

        // Token: 0x04000482 RID: 1154
        private Color BOX_LINECOLOR;

        // Token: 0x04000483 RID: 1155
        public ControlDesign parentcontrol;

        // Token: 0x04000484 RID: 1156
        private int[] mySel;

        // Token: 0x04000485 RID: 1157
        private Label[,] _lbl;

        // Token: 0x04000486 RID: 1158
        private bool[] myselectzt;

        // Token: 0x04000487 RID: 1159
        private int _startl;

        // Token: 0x04000488 RID: 1160
        private int _startt;

        // Token: 0x04000489 RID: 1161
        private int _startw;

        // Token: 0x0400048A RID: 1162
        private int _starth;

        // Token: 0x0400048B RID: 1163
        private bool _dragging;

        // Token: 0x0400048C RID: 1164
        private Cursor[] _arrArrow;

        // Token: 0x0400048D RID: 1165
        private Control[] MyControl;

        // Token: 0x0400048E RID: 1166
        private int source_x;

        // Token: 0x0400048F RID: 1167
        private int source_y;

        // Token: 0x04000490 RID: 1168
        private Rectangle[] PreRect;

        // Token: 0x04000491 RID: 1169
        private Rectangle[] NewRect;

        // Token: 0x04000492 RID: 1170
        private Rectangle[] mypos;

        // Token: 0x04000493 RID: 1171
        public PropertyGrid pg;

        // Token: 0x04000494 RID: 1172
        public Label pgs;

        // Token: 0x04000495 RID: 1173
        private bool ishandlemousedown;

        // Token: 0x04000496 RID: 1174
        private bool disposedValue;

        // Token: 0x02000034 RID: 52
        // (Invoke) Token: 0x06000852 RID: 2130
        public delegate void ShowStatusEventHandler(string tt, Control myc);
    }
}
