<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebPageSeparated.aspx.cs" Inherits="WebPageSeparated" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background: url(kA7v6qNbAjM.jpg) center fixed space; ">
     
    
    <h1 style="background-position: left center; color: black; font-family: 'Intro Caps'; font-size: 52px; font-weight: lighter; 
   font-style: inherit; font-variant: inherit; text-transform: inherit; height: 70px; width: 1729px; text-decoration: none;" >


    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;HOW GOOD IS YOUR START UP?

    </h1>
    
    <hr   style="color: black; width: 39%; font-style: normal; font-weight: 500;"> 
   
         </hr>
    
   

    <form id="form1" runat="server"> 
        
        <div style="height: 166px; width: 438px; margin-bottom: 85px; margin-right: 0px;">
            
             <h2 style="color: black; font-family: 'Eras ITC'; font-size: 31px; font-weight: 900; 
   font-style: inherit; font-variant: inherit; text-transform: inherit; height: 11px; width: 419px;" >  
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 &nbsp;&nbsp;
     <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
         style=" border-width: thin; color: black; border-top-color: black;  
 width: 188px; margin-left: 0px; border-bottom-color: black; 
 border-color: black; font-family: 'Eras ITC'; font-weight: 100; 
 background-color: white; font-size: 20px; height: 27px; text-decoration: none;">
       <asp:ListItem>Choose a sphere</asp:ListItem>
       <asp:ListItem>IT</asp:ListItem>
       <asp:ListItem>Retail</asp:ListItem>
       <asp:ListItem>Restaurant</asp:ListItem>
       <asp:ListItem>Production</asp:ListItem>
       <asp:ListItem>Services</asp:ListItem>
                 </asp:DropDownList>
                 &nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h2>
             <h2 style="color: black; font-family: 'Eras ITC'; font-size: 31px; font-weight: 900; 
   font-style: inherit; font-variant: inherit; text-transform: inherit; height: 11px; width: 419px;" >  
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 &nbsp;&nbsp;&nbsp; </h2>
            
             <br />
            &nbsp;<div style="margin-right: 1181px; height: 307px; width: 1373px; margin-top: 0px;">

                <h3 color: black; font-family: 'Eras ITC'; style="width: 256px; margin-left: 872px; font-family: 'Eras ITC';
 font-size: 28px; font-weight: lighter; height: 40px;" > Answer:<asp:TextBox ID="TextBox2" 
     runat="server" Height="84px" style="margin-left: 0px; margin-right: 0px" Width="435px"></asp:TextBox>
                    </h3>
                 <h2 style="color: black; font-family: 'Eras ITC'; font-size: 28px; font-weight: lighter; 
   font-style: inherit; font-variant: inherit; text-transform: inherit; height: 18px; width: 223px; margin-left: 102px; margin-bottom: 9px;" >  
               Describe your idea</h2>

        <asp:TextBox ID="TextBox1" runat="server" Height="79px" Width="387px" BorderStyle="Solid" 
            BackColor ="White" BorderColor="Black" BorderWidth="1px" ForeColor="Black" 
            style="margin-right: 45px; margin-left: 52px; margin-top: 5px; margin-bottom: 3px;" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox>
                 <br />

             <asp:Button ID="Button1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Outset"  ForeColor="Black"
             OnClick="Button1_Click" style="font-family: 'Eras ITC';margin-left: 55px; margin-right: 12px; 
             margin-bottom: 0px; margin-top: 1px;" Text="Ok"  Width="86px" Height="35px" />
             <br />
             <h2 style="color: black; font-family: 'Eras ITC'; font-size: 28px; font-weight: lighter; 
   font-style: inherit; font-variant: inherit; text-transform: inherit; height: 11px; width: 224px; margin-left: 102px;" >  

                 &nbsp;</h2>
                 <h2 style="color: black; font-family: 'Eras ITC'; font-size: 28px; font-weight: lighter; 
   font-style: inherit; font-variant: inherit; text-transform: inherit; height: 11px; width: 224px; margin-left: 102px;" >  
                     &nbsp;</h2>
             <br />
             <br />
             
             <br />
             <br />
             <br />
        
        </div>
             </div>

    </form>
</body>
</html>
