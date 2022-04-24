<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="GUCera.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        #table {
            text-align:center;
        }
        .rtable {
  /*!
  // IE needs inline-block to position scrolling shadows otherwise use:
  // display: block;
  // max-width: min-content;
  */
  text-align:center;
  display: inline-block;
  vertical-align: top;
  max-width: 100%;
  
  overflow-x: auto;
  
  // optional - looks better for small cell values
  white-space: nowrap;

  border-collapse: collapse;
  border-spacing: 0;
}

.rtable,
.rtable--flip tbody {
  // optional - enable iOS momentum scrolling
  -webkit-overflow-scrolling: touch;
  
  // scrolling shadows
  background: radial-gradient(left, ellipse, rgba(0,0,0, .2) 0%, rgba(0,0,0, 0) 75%) 0 center,
              radial-gradient(right, ellipse, rgba(0,0,0, .2) 0%, rgba(0,0,0, 0) 75%) 100% center;
  background-size: 10px 100%, 10px 100%;
  background-attachment: scroll, scroll;
  background-repeat: no-repeat;
}

// change these gradients from white to your background colour if it differs
// gradient on the first cells to hide the left shadow
.rtable td:first-child,
.rtable--flip tbody tr:first-child {
  background-image: linear-gradient(to right, rgba(255,255,255, 1) 50%, rgba(255,255,255, 0) 100%);
  background-repeat: no-repeat;
  background-size: 20px 100%;
}

// gradient on the last cells to hide the right shadow
.rtable td:last-child,
.rtable--flip tbody tr:last-child {
  background-image: linear-gradient(to left, rgba(255,255,255, 1) 50%, rgba(255,255,255, 0) 100%);
  background-repeat: no-repeat;
  background-position: 100% 0;
  background-size: 20px 100%;
}

.rtable th {
  font-size: 11px;
  text-align: left;
  text-transform: uppercase;
  background: #f2f0e6;
}

.rtable th,
.rtable td {
  padding: 6px 12px;
  border: 1px solid #d9d7ce;
}

.rtable--flip {
  display: flex;
  overflow: hidden;
  background: none;
}

.rtable--flip thead {
  display: flex;
  flex-shrink: 0;
  min-width: min-content;
}

.rtable--flip tbody {
  display: flex;
  position: relative;
  overflow-x: auto;
  overflow-y: hidden;
}

.rtable--flip tr {
  display: flex;
  flex-direction: column;
  min-width: min-content;
  flex-shrink: 0;
}

.rtable--flip td,
.rtable--flip th {
  display: block;
}

.rtable--flip td {
  background-image: none !important;
  // border-collapse is no longer active
  border-left: 0;
}

        body {
            background-color: #B0C4DE;
        }

        h1,h3 {
            text-align: center;

        }
         h1{
            font-family: sans-serif;
            font-size: 50px;
            margin: 0 0 10px 0;
            color: #4682B4;

         }
      
         h5{
           margin-left: 80px;

         }
        .form {
           background-color: #F0F8FF;
            box-shadow: 0 30px 60px 0 rgba(90, 116, 148, 0.4);
            border-radius: 5px;
            max-width: 480px;
            margin-left: auto;
            margin-right: auto;
            padding-top: 5px;
            padding-bottom: 5px;
            left: 0;
            right: 0;
            position: absolute;
            border-top: 5px solid  #4682B4;
           /*   z-index: 1; */
           
         }
        .title{
          display: block;
          font-family: sans-serif;
         
          width: 300px;
         }
        .box {
           background-color:  #ebebeb;
        
         }
         .box:hover {
         border-bottom: 5px solid  #B0C4DE;
         height: 30px;
         width: 380px;
         transition: ease 0.5s;
          }
         .formEntry {
          display: block;
          margin: 30px auto;
          min-width: 300px;
          padding: 10px;
          border-radius: 2px;
          border: none;
          transition: all 0.5s ease 0s;
          }
         .submit {
           width: 200px;
           color: white;
            background-color: #4682B4;
          font-size: 20px;
          }

         .submit:hover {
         box-shadow: 15px 15px 15px 5px rgba(78, 72, 77, 0.219);
         transform: translateY(-3px);
          width: 300px;
          border-top: 5px solid #0e3750;
          border-radius: 0%;
         }
         .buttonHolder{
           text-align:center;}
         
         .pageTitle{
         font-size: 2em;
         font-weight: bold;
          font-family: sans-serif;
         }
         .item{
             margin-left:80px;
         }
         #Label1 {
               color:red;
               font-size: 20px;

         }
    </style>
    <form id="form1" class="form" runat="server">
          <h1 class="pageTitle">Welcome to GUCera!</h1>
        <h1 class="pageTitle">
       Registeration</h1>
        <h5 class="title">Firstname :</h5>
        <asp:TextBox ID="firstname" class="box formEntry" runat="server"></asp:TextBox>
        <h5 class="title">Lastname :</h5>
         <asp:TextBox ID="lastname" class="box formEntry" runat="server"></asp:TextBox>
        <h5 class="title">Password :</h5>
        <asp:TextBox ID="password" class="box formEntry" runat="server"></asp:TextBox>
        <h5 class="title">gender :</h5>
         <asp:RadioButtonList ID="gender"  runat="server">
             <asp:ListItem class="item" Text="female"/>
             <asp:ListItem  class="item"  Text="male"/>
             </asp:RadioButtonList>
        <h5 class="title">Email: :</h5>
        <asp:TextBox ID="email" class="box formEntry" runat="server"></asp:TextBox>
         <h5 class="title">Address :</h5>
        <asp:TextBox ID="address" class="box formEntry" runat="server"></asp:TextBox>

        <div class="buttonHolder">
        <asp:Button ID="student" runat="server" class="submit" Text="Register as Student" OnClick="student_Click" /><br />
            <asp:Button ID="instructor" runat="server" class="submit" Text="Register as Instructor" OnClick="instructor_Click" /><br />
            <asp:Button ID="Button1" class="submit" runat="server" Text="go to login" OnClick="Button1_Click" /><br />
             <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
         <div id="table" runat="server">

         </div>
       
    </form>
</body>
</html>
