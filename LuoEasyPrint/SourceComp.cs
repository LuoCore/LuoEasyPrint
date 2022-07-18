using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LuoEasyPrint
{
	// Token: 0x0200003A RID: 58
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class SourceComp
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00057AA4 File Offset: 0x00055CA4
		public Assembly cpAssembly
		{
			get
			{
				return this.m_Assembly;
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00057ABC File Offset: 0x00055CBC
		public SourceComp()
		{
			this.m_RefAssemblies = new string[]
			{
				"System.dll",
				"System.Data.dll"
			};
			this.m_Source = "";
			this.m_Is_Default = true;
			this.m_Compiled = false;
			this.m_Compiler = new VBCodeProvider();
			this.m_CompilerParameters = new CompilerParameters();
			CompilerParameters compilerParameters = this.m_CompilerParameters;
			compilerParameters.GenerateExecutable = false;
			compilerParameters.GenerateInMemory = false;
			this.Add_CompilerParameters();
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00004742 File Offset: 0x00002942
		private void Add_CompilerParameters()
		{
			this.m_CompilerParameters.ReferencedAssemblies.AddRange(this.m_RefAssemblies);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0000475A File Offset: 0x0000295A
		public void Add_CompilerParameters(string[] RefAssemblies)
		{
			this.m_RefAssemblies = RefAssemblies;
			this.m_CompilerParameters.ReferencedAssemblies.Clear();
			this.Add_CompilerParameters();
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00057B3C File Offset: 0x00055D3C
		private void BuildDefaultSource()
		{
			CodeBuilder codeBuilder = new CodeBuilder();
			CodeBuilder codeBuilder2 = codeBuilder;
			codeBuilder2.AppendCode("Imports System");
			codeBuilder2.AppendCode("Imports System.Data");
			codeBuilder2.AppendCode("Imports System.Math");
			codeBuilder2.AppendCode("Imports Microsoft.VisualBasic");
			codeBuilder2.AppendCode("Imports Microsoft.Win32 ");
			codeBuilder2.AppendCode(" Imports System.Text");
			codeBuilder2.AppendCode("Imports System.Collections");
			codeBuilder2.AppendCode("Imports System.Drawing");
			codeBuilder2.AppendCode("Imports System.Drawing.Printing");
			codeBuilder2.AppendCode("Imports System.IO");
			codeBuilder2.AppendCode("Imports System.IO.Compression");
			codeBuilder2.AppendCode("Imports System.Net");
			codeBuilder2.AppendCode("Imports System.Data.Common");
			codeBuilder2.AppendCode("Imports System.Data.Sql");
			codeBuilder2.AppendCode("Imports System.Data.SqlClient");
			codeBuilder2.AppendCode("Imports System.Data.Odbc");
			codeBuilder2.AppendCode("Imports System.Data.OleDb");
			codeBuilder2.AppendCode();
			codeBuilder2.AppendCode("Public Class tmpClass");
			codeBuilder2.AppendCode("   Public Function GetExpressionValue() As Object");
			codeBuilder2.AppendCode("       Dim Result As Object");
			codeBuilder2.AppendCode("       Result={0}");
			codeBuilder2.AppendCode("       Return Result");
			codeBuilder2.AppendCode("   End Function");
			this.AddSmallToBig(codeBuilder);
			this.AddBigNumber(codeBuilder);
			this.AddBigMonth(codeBuilder);
			this.AddBigDay(codeBuilder);
			this.AddBigYear(codeBuilder);
			this.AddSmallToBig2(codeBuilder);
			codeBuilder2.AppendFromFile("definesrcipt.txt");
			codeBuilder2.AppendCode("End Class");
			this.m_Source = codeBuilder.ToString();
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00004779 File Offset: 0x00002979
		public void SetSource(string Source)
		{
			this.m_Source = Source;
			this.m_Compiled = false;
			this.m_Is_Default = false;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00057CA4 File Offset: 0x00055EA4
		public void GetSourceFormFile(string SourceFileName)
		{
			CodeBuilder codeBuilder = new CodeBuilder();
			codeBuilder.AppendFromFile(SourceFileName);
			this.m_Source = codeBuilder.ToString();
			this.m_Compiled = false;
			this.m_Is_Default = false;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00057CD8 File Offset: 0x00055ED8
		public void Complile()
		{
			if (String.Compare(this.m_Source, "", false) == 0)
			{
				this.BuildDefaultSource();
			}
			if (this.m_Is_Default)
			{
				this.m_Source = string.Format(this.m_Source, this.m_Expression);
			}
			CompilerResults compilerResults = this.m_Compiler.CompileAssemblyFromSource(this.m_CompilerParameters, new string[]
			{
				this.m_Source
			});
			if (compilerResults.Errors.HasErrors)
			{
				string text = "编译错误:\r\n";
				try
				{
					foreach (object obj in compilerResults.Errors)
					{
						CompilerError compilerError = (CompilerError)obj;
						text = text + compilerError.ErrorText + "\r\n";
					}
				}
				finally
				{
					
				}
				throw new Exception("编译错误: " + text);
			}
			this.m_Assembly = compilerResults.CompiledAssembly;
			this.m_Compiled = true;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00057DD8 File Offset: 0x00055FD8
		public object GetExpressionValue(string Expression)
		{
			object result;
			if (!this.m_Is_Default)
			{
				Interaction.MsgBox("所用的代码不是默认代码，此函数无效", MsgBoxStyle.OkOnly, "提示信息");
				result = null;
			}
			else
			{
				if (!this.m_Compiled)
				{
					this.m_Expression = Expression;
					this.Complile();
					this.m_tmpClass = RuntimeHelpers.GetObjectValue(this.m_Assembly.CreateInstance("tmpClass"));
					this.m_MethodInfo = this.m_tmpClass.GetType().GetMethod("GetExpressionValue");
				}
				object objectValue = RuntimeHelpers.GetObjectValue(this.m_MethodInfo.Invoke(RuntimeHelpers.GetObjectValue(this.m_tmpClass), null));
				this.m_Compiled = false;
				result = objectValue;
			}
			return result;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00057E74 File Offset: 0x00056074
		private void AddSmallToBig(CodeBuilder tt)
		{
			tt.AppendCode("   Private Function SmallToBig(Byval ad_number As Decimal) As String");
			tt.AppendCode("if isnumeric(ad_number)=false then");
			tt.AppendCode("return ad_number");
			tt.AppendCode("end if ");
			tt.AppendCode("Dim ls_hz1(15) As String");
			tt.AppendCode("Dim ls_hz2(15) As String");
			tt.AppendCode("Dim ls_return As String");
			tt.AppendCode("Dim ls_temp As String");
			tt.AppendCode("Dim ls_argument As String");
			tt.AppendCode(" Dim li_1 As Short");
			tt.AppendCode("Dim li_len As Short");
			tt.AppendCode("Dim lb_first_zero As Boolean");
			tt.AppendCode(" ls_hz1(1) = \"分\"");
			tt.AppendCode("ls_hz1(2) = \"角\"");
			tt.AppendCode("ls_hz1(3) = \"\"");
			tt.AppendCode("ls_hz1(4) = \"元\"");
			tt.AppendCode("ls_hz1(5) = \"拾\"");
			tt.AppendCode("ls_hz1(6) = \"佰\"");
			tt.AppendCode("ls_hz1(7) = \"仟\"");
			tt.AppendCode("ls_hz1(8) = \"万\"");
			tt.AppendCode("ls_hz1(9) = \"拾\"");
			tt.AppendCode("ls_hz1(10) = \"佰\"");
			tt.AppendCode("ls_hz1(11) = \"仟\"");
			tt.AppendCode("ls_hz1(12) = \"亿\"");
			tt.AppendCode("ls_hz1(13) = \"拾\"");
			tt.AppendCode("ls_hz1(14) = \"佰\"");
			tt.AppendCode("ls_hz1(15) = \"仟\"");
			tt.AppendCode("ls_hz2(1) = \"壹\"");
			tt.AppendCode("ls_hz2(2) = \"贰\"");
			tt.AppendCode("ls_hz2(3) = \"叁\"");
			tt.AppendCode("ls_hz2(4) = \"肆\"");
			tt.AppendCode(" ls_hz2(5) = \"伍\"");
			tt.AppendCode("ls_hz2(6) = \"陆\"");
			tt.AppendCode(" ls_hz2(7) = \"柒\"");
			tt.AppendCode("ls_hz2(8) = \"捌\"");
			tt.AppendCode("ls_hz2(9) = \"玖\"");
			tt.AppendCode("ls_hz2(10) = \"零\"");
			tt.AppendCode("If ad_number = 0 Then");
			tt.AppendCode("SmallToBig = \"零元整\"");
			tt.AppendCode("Exit function");
			tt.AppendCode("End If");
			tt.AppendCode("ls_argument = Format(ad_number, \"############0.00\")");
			tt.AppendCode("If Len(ls_argument) > 15 Then");
			tt.AppendCode("SmallToBig = \"\"");
			tt.AppendCode("MsgBox(\"大写金额转换时出错,本程序允许的最大可转换金额为9仟亿,超过此金额时不能转换\")");
			tt.AppendCode("return \"\"");
			tt.AppendCode("Exit function");
			tt.AppendCode("End If");
			tt.AppendCode(" If Len(ls_argument) <= 15 Then");
			tt.AppendCode("ls_argument = \" \" & ls_argument");
			tt.AppendCode("End If");
			tt.AppendCode(" If Microsoft.VisualBasic.Right(ls_argument, 1) = \"0\" Then");
			tt.AppendCode("ls_return = \"整\"");
			tt.AppendCode("Else");
			tt.AppendCode("ls_return = \"\"");
			tt.AppendCode(" End If");
			tt.AppendCode("Do While True");
			tt.AppendCode("mystart:");
			tt.AppendCode("li_1 = li_1 + 1");
			tt.AppendCode("li_len = Len(ls_argument)");
			tt.AppendCode("ls_temp = Microsoft.VisualBasic.Right(ls_argument, 1)");
			tt.AppendCode("ls_argument = Microsoft.VisualBasic.Left(ls_argument, li_len - 1)");
			tt.AppendCode("  If ls_temp = \" \" Or (ls_argument = \" \" And ls_temp = \"0\") Then");
			tt.AppendCode("Exit Do");
			tt.AppendCode("End If");
			tt.AppendCode("If ls_temp = \".\" Then");
			tt.AppendCode("GoTo mystart");
			tt.AppendCode("End If");
			tt.AppendCode("If ls_temp = \"-\" Then");
			tt.AppendCode("ls_return = \"负\" & ls_return");
			tt.AppendCode("GoTo mystart");
			tt.AppendCode("End If");
			tt.AppendCode("If ls_temp <> \"0\" Then");
			tt.AppendCode("ls_return = ls_hz2(CInt(ls_temp)) & ls_hz1(li_1) & ls_return");
			tt.AppendCode("lb_first_zero = True");
			tt.AppendCode("Else");
			tt.AppendCode("If lb_first_zero Then");
			tt.AppendCode("If (li_1 <> 4 And li_1 <> 2) Or CSng(ls_argument) <> 0 Then");
			tt.AppendCode("ls_return = \"零\" & ls_return");
			tt.AppendCode("End If");
			tt.AppendCode("lb_first_zero = False");
			tt.AppendCode("End If");
			tt.AppendCode("If li_1 = 12 Or li_1 = 8 Then");
			tt.AppendCode("If Microsoft.VisualBasic.Right(ls_argument, 3) <> \"000\" Then ls_return = ls_hz1(li_1) & ls_return");
			tt.AppendCode("End If");
			tt.AppendCode("If li_1 = 4 Then");
			tt.AppendCode("If CSng(ls_argument) <> 0 Then ls_return = ls_hz1(li_1) & ls_return");
			tt.AppendCode("End If");
			tt.AppendCode("End If");
			tt.AppendCode("Loop");
			tt.AppendCode("SmallToBig = ls_return");
			tt.AppendCode("End Function");
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0005827C File Offset: 0x0005647C
		private void AddBigNumber(CodeBuilder tt)
		{
			tt.AppendCode("   Private Function myBig(Byval myn as string) As String");
			tt.AppendCode(" Dim myr As String");
			tt.AppendCode("Select Case myn");
			tt.AppendCode("Case \"0\"");
			tt.AppendCode("myr = \"零\"");
			tt.AppendCode("Case \"1\"");
			tt.AppendCode("myr = \"壹\"");
			tt.AppendCode("    Case \"2\"");
			tt.AppendCode("myr = \"贰\"");
			tt.AppendCode("Case \"3\"");
			tt.AppendCode("myr = \"叁\"");
			tt.AppendCode("Case \"4\"");
			tt.AppendCode("myr = \"肆\"");
			tt.AppendCode("Case \"5\"");
			tt.AppendCode("myr = \"伍\"");
			tt.AppendCode("Case \"6\"");
			tt.AppendCode("myr = \"陆\"");
			tt.AppendCode("   Case \"7\"");
			tt.AppendCode("myr = \"柒\"");
			tt.AppendCode("Case \"8\"");
			tt.AppendCode("myr = \"捌\"");
			tt.AppendCode("Case \"9\"");
			tt.AppendCode("myr = \"玖\"");
			tt.AppendCode("Case Else");
			tt.AppendCode(" myr = \"\"");
			tt.AppendCode("End Select");
			tt.AppendCode("mybig = myr");
			tt.AppendCode("end function ");
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000583C4 File Offset: 0x000565C4
		private void AddBigDay(CodeBuilder tt)
		{
			tt.AppendCode("private function BigDay(Byval myd As Date) As String");
			tt.AppendCode(" Dim myr As String = \"\"");
			tt.AppendCode(" Dim xX As Short");
			tt.AppendCode("xX = myd.Day()");
			tt.AppendCode("If xX < 10 Then");
			tt.AppendCode("myr = \"零\" & mybig(CStr(xX))");
			tt.AppendCode("ElseIf xX = 10 Then");
			tt.AppendCode("myr = \"零壹拾\"");
			tt.AppendCode("ElseIf xX = 20 Then");
			tt.AppendCode("myr = \"零贰拾\"");
			tt.AppendCode("ElseIf xX = 30 Then");
			tt.AppendCode("myr = \"零叁拾\"");
			tt.AppendCode("Else");
			tt.AppendCode("myr = mybig(Left(CStr(xX), 1)) & \"拾\" & mybig(Right(CStr(xX), 1))");
			tt.AppendCode("End If");
			tt.AppendCode("return myr");
			tt.AppendCode("end function");
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00058490 File Offset: 0x00056690
		private void AddBigMonth(CodeBuilder tt)
		{
			tt.AppendCode(" Public Function BigMonth(ByRef myd As Date) As String");
			tt.AppendCode("Dim myr As String = \"\"");
			tt.AppendCode(" Dim xX As Short");
			tt.AppendCode("xX = Month(myd)");
			tt.AppendCode("If xX <= 2 Then");
			tt.AppendCode("myr = \"零\" & mybig(CStr(xX))");
			tt.AppendCode("ElseIf xX <= 9 Then");
			tt.AppendCode(" myr = mybig(CStr(xX))");
			tt.AppendCode(" myr = \"零\" & myr");
			tt.AppendCode(" End If");
			tt.AppendCode("If xX = 10 Then");
			tt.AppendCode("myr = \"零壹拾\"");
			tt.AppendCode("End If");
			tt.AppendCode("If xX = 11 Then");
			tt.AppendCode("myr = \"壹拾壹\"");
			tt.AppendCode("End If");
			tt.AppendCode("If xX = 12 Then");
			tt.AppendCode("myr = \"壹拾贰\"");
			tt.AppendCode("End If");
			tt.AppendCode("BigMonth = myr");
			tt.AppendCode("End function");
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00058588 File Offset: 0x00056788
		private void AddBigYear(CodeBuilder tt)
		{
			tt.AppendCode(" Public Function BigYear(ByRef myd As Date) As String");
			tt.AppendCode("Dim myr As String");
			tt.AppendCode("myr = \"\"");
			tt.AppendCode("Dim temp As String");
			tt.AppendCode("temp = CStr(Year(myd))");
			tt.AppendCode("myr = mybig(Mid(temp, 1, 1))");
			tt.AppendCode("myr = myr & mybig(Mid(temp, 2, 1))");
			tt.AppendCode("myr = myr & mybig(Mid(temp, 3, 1))");
			tt.AppendCode("myr = myr & mybig(Mid(temp, 4, 1))");
			tt.AppendCode("BigYear = myr");
			tt.AppendCode(" End function");
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00058614 File Offset: 0x00056814
		private void AddSmallToBig2(CodeBuilder tt)
		{
			tt.AppendCode("Private Function SmallToBig2(ByVal je As Decimal) As String");
			tt.AppendCode("  je = System.Math.Round(je, 2)");
			tt.AppendCode("dim je2 as long  =clng (je * 100)");
			tt.AppendCode("Dim ss As String");
			tt.AppendCode("ss = CStr(je2)");
			tt.AppendCode("Dim mys As String");
			tt.AppendCode("mys = \"\"");
			tt.AppendCode("For i As Integer = 0 To ss.Length - 1");
			tt.AppendCode("mys = mys & mybig(ss(i))");
			tt.AppendCode("Next");
			tt.AppendCode("Return mys");
			tt.AppendCode("End function");
		}

		// Token: 0x0400052C RID: 1324
		private VBCodeProvider m_Compiler;

		// Token: 0x0400052D RID: 1325
		private CompilerParameters m_CompilerParameters;

		// Token: 0x0400052E RID: 1326
		private string[] m_RefAssemblies;

		// Token: 0x0400052F RID: 1327
		private string m_Source;

		// Token: 0x04000530 RID: 1328
		private bool m_Is_Default;

		// Token: 0x04000531 RID: 1329
		private bool m_Compiled;

		// Token: 0x04000532 RID: 1330
		private Assembly m_Assembly;

		// Token: 0x04000533 RID: 1331
		private object m_tmpClass;

		// Token: 0x04000534 RID: 1332
		private MethodInfo m_MethodInfo;

		// Token: 0x04000535 RID: 1333
		private string m_Expression;
	}
}
