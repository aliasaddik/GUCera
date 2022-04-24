<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="grades.aspx.cs" Inherits="GUCera.grades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        #Label5{
    font-family: sans-serif;
   font-size: 25px;
   

}
        #Label4{
   font-family: sans-serif;
   font-size: 20px;
   margin-bottom:40px;
 
   

}
        h1{
            font-family: sans-serif;
            font-size: 50px;
            margin: 0 0 10px 0;
            color: #4682B4;

        }
        #Label1,#Label2,#Label3{
            font-family: sans-serif;
            font-size: 20px;
            margin: 0 0 10px 0;
            color: #4682B4;
        }
         .submit {
           width: 200px;
           color: white;
           background-color: 	#D3D3D3;
          font-size: 20px;
            margin-top: 17px;
            margin-bottom:20px;
        }

         .submit:hover {
         box-shadow: 15px 15px 15px 5px rgba(78, 72, 77, 0.219);
         transform: translateY(-3px);
          width: 300px;
          border-top: 5px solid #0e3750;
          border-radius: 0%;
         }
         

         #card:hover {
           box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
          }

          .container {
            padding: 2px 16px;
           }
          #card{
              margin-top:50px;
              margin-left:260px;
              box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
              transition: 0.3s;
              width: 60%;
              border-radius: 5px;
             background-color: #F0F8FF;
            
          }
          body{
             background-color: #B0C4DE;
             
          }
         #form1{
             text-align: center;
         }
       


    </style>

    <div id="card">
    <form id="form1" runat="server">
        <h1>View Your Grades</h1>
       <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Course ID :"></asp:Label><br />
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox><br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter assignment number : "></asp:Label><br />
            <asp:TextBox ID="no" runat="server"></asp:TextBox><br />
        </div>
        
            <asp:Label ID="Label3" runat="server" Text="Choose sssignment type : "></asp:Label><br />
        <div class="list">
            <asp:RadioButtonList align="center"  ID="typeofAssign" runat="server" style="height: 80px">
                
                 <asp:ListItem class="item"  Text="Quiz"/>
                 <asp:ListItem class="item" Text="Project"/>
                 <asp:ListItem class="item" Text="Exam"/>
                    
            </asp:RadioButtonList><br />
            </div>
           
            <asp:Button ID="viewG" class="submit" runat="server" Text="View grade " OnClick="viewG_Click" /><br />
             <asp:Label ID="Label5" runat="server" Text=""></asp:Label><br />
                
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
       
    </form>
     </div>
</body>
</html>
