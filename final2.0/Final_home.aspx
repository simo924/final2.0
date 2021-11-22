<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Final_home.aspx.cs" Inherits="EX1.Final_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   	<style>
	body{
		background-image:url('Image/dog.gif');
		background-repeat:no-repeat;
		background-size:70%;
		background-position:center;
		
	}
	.bottom{
		color:black;
		border: 2px solid #BC8F8F;
		border-radius: 10px 10px 10px 10px;
		font-size:20px;
		width:150px;
		height:30px;
		margin-left:720px;
		margin-top:500px;
		display:block;
		text-align:center;
		padding:5px;
		padding-top:2px;
		
	}
	.bottom a{
		font-weight:bold;
		color:gray;
		text-decoration:none;
	}
	.bottom:hover {
		transition:3s;
		opacity:1;
	}
	.bottom a:hover {
		color: #BC8F8F;
		transition:2s;
		font-size:35px;
	}
	</style>
</head>

<body>
    <form id="form1" runat="server">
    <div class="bottom">
		<a href="Final_index.aspx" >welcome </a>
	</div>
    </form>
</body>
</html>
