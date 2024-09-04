<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Employeemanagement.Employee" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Management System</title>
    <style type="text/css">
        .auto-style1 {
            width: 27%;
        }
        .auto-style2 {
            text-align: center;
            background-color: aqua;
        }
        .auto-style3 {
            width: 241px;
            text-align: center;
            background-color:indianred;
            
        }
        .auto-style4 {
            text-align: center;
           
            
        }
        .auto-style5 {
            text-align: center;
           background-color:chartreuse;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="auto-style2">Employee Management System</h2>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="EmployeeID"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtEmployeeId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="FirstName"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="LastName"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" Text="Salary"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="btnSave" runat="server" BackColor="#FF9900" OnClick="btnSave_Click" Text="Save" />
                        <asp:Button ID="btnUpdate" runat="server" BackColor="#FF9900" OnClick="btnUpdate_Click" Text="Update" />
                        <asp:Button ID="btnDelete" runat="server" BackColor="#FF9900" OnClick="btnDelete_Click" Text="Delete" />
                        <asp:Button ID="btnNew" runat="server" BackColor="#FF9900" OnClick="btnNew_Click" Text="New" />
                    </td>
                </tr>
            </table>
            <br />
            <div class="auto-style5">
                 
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeID" DataSourceID="SqlDataSource1">
                    
                    <Columns>
                        <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID" />
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                        <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />

                    </Columns>
                </asp:GridView>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Employeemanagementsyatem_dbConnectionString %>" 
                SelectCommand="SELECT [EmployeeID], [FirstName], [LastName], [Email], [Department], [Salary] FROM [Employees]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

