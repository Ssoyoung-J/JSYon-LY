<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%@ page import="java.sql.*, java.util.*, java.text.*"%>
<!DOCTYPE html>
<%
    String CurrentResult="";
    String p ="";

    p=(String)session.getAttribute("TotalWin");
    if(p==null){
    	p="0";
    }
    int TotalWin = Integer.parseInt(p);
    if(p==null){
    	p="0";}
    int TotalLose = Integer.parseInt(p);
    p = (String)session.getAttribute("TotalDrawn");
    if(p==null){
    	p = "0";
    }
    int TotalDrawn = Integer.parseInt(p);
    float Win =((float)TotalWin/(float)(TotalWin+TotalLose+TotalDrawn));
    int select = 0,  Random =0;
    String Me="",Sys="";
    class RSP{
    	String select="";
    	String RSP(int a){
    		switch(a){
    		case 1 :
    			select ="����";
    			break;
    		case 2 :
    			select ="����";
    			break;
    		case 3 :
    			select ="��";
    			break;
    		default:
    			select="";
    		}
    		return select;
    	}
    }
    if(request.getParameter("select")!=null){
    	select = Integer.parseInt(request.getParameter("select"));
    	  Random rand = new Random();
    	  int r = rand.nextInt(3)+1; 
    	switch(r){
    	case 1:
    		if(select==2){
    			TotalWin++;
    			CurrentResult="�¸�";
    		}else if(select !=r){
    			TotalLose++;
    			CurrentResult = "�й�";
    		}break;
    	case 2 :
    		if(select==3){
    			TotalWin++;
    			CurrentResult="�¸�";
    		}else if(select !=r){
    			TotalLose++;
    			CurrentResult = "�й�";
    		}break;
    	default:
    		if(select==1){
    			TotalWin++;
    			CurrentResult="�¸�";
    		}else if(select !=r){
    			TotalLose++;
    			CurrentResult = "�й�";
    		}
    		
    	}
    	if(select==r){
    		TotalDrawn++;
    		CurrentResult="���º�";
    	}
    	RSP selection = new RSP();
    	Me = selection.RSP(select);
    	Sys = selection.RSP(r);
    	
    	session.setAttribute("TotalWin",Integer.toString(TotalWin));
    	session.setAttribute("TotalLose",Integer.toString(TotalLose));
    	session.setAttribute("TotalDrawn",Integer.toString(TotalDrawn));
    			}
   %>
<html>
<head>
<meta charset="EUC-KR">
<title>���������� ����</title>
<style type=text/css>
       td  {font-size:15pt;font-family:���� �ٰռ��� M;}
       h1  {font-size:25pt;font-family:���� �ٰռ��� B;}</style>
</head>
<body>
<div align="center">
<h1>���������� ����</h1>
<table width="600"  border="1" Cellspacing="1">
<tr height=30 >
<td width="100" align ="center"  bgcolor="#ffccff">�� </td>
<td width="500" align ="left"><%=Me %>
</td>
</tr>
<tr height=30>
<td width="100" align ="center"  bgcolor="#ffccff">�ý���</td>
<td width="500" align ="left"> <%=Sys %></td>
</tr>
<tr height=30>
<td width="100" align ="center"  bgcolor="#ffccff">���</td>
<td width="500" align ="left"><%=CurrentResult %></td>
</tr>
</table>
<form name="game" action="rsp.jsp" method="post" >
<input type="submit"  name = select  value="1"> ����
<input type="submit"  name = select  value="2"> ����
<input type="submit"  name = select  value="3"> ��
<div align="center">��ü ����Ƚ�� : <%=TotalWin+TotalLose+TotalDrawn%>   �·� : <%=Win %></div>
</form>

