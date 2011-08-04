<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ProductsList.Models.Product>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Details</title>
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div>
        <%
            var products = new List<ProductsList.Models.Product>(){
            new ProductsList.Models.Product { Id=1 , Name = "Book" , Price= 20.75M , OnSale = false},
            new ProductsList.Models.Product { Id=2 , Name = "Bat" , Price= 21.0M , OnSale = false},
            new ProductsList.Models.Product { Id=3 , Name = "Ball" , Price= 22.50M , OnSale = true}  
            };
        %>
        <h2>
            Products List</h2>
        
        <div>
        Name Price
        </div>

        <%
            var total = 0M;
            foreach (var product in products)
            {
                string style = product.OnSale ? "background-color: red" : "background-color: white";
        %>
        <div style="<%=style%>">
            <%= product.Name%>
            <%=product.Price.ToString()%>
        </div>
        <%
            total += product.Price;         
            }
        %>
        Total : 
        <%=total %>
    </div>
</body>
</html>
