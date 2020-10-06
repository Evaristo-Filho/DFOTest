
app.factory('userFactory', function()
{
    return { 
        getInstance: function()
        {
            return new User();
        }
    }
}) 

function User() {
    this.Id=""
    this.Name="";
    this.Age="";
    this.Address="";
    }