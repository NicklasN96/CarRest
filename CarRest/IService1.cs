using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //Get Method to get all the Cars
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "api/books/getAllBooks")]
        IList<Car> GetBooks();

        // TODO: Add your service operations here

        //POST Method to add a car
        [OperationContract]
        [WebInvoke(Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "api/books")]
        Car AddCar(Car car);


        //PUT Method to update a car
        [OperationContract]
        [WebInvoke(Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/books/{modelYear}")]
        Car UpdateCar(string modelYear, Car car);


        //DELETE Method to delete a car
        [OperationContract]
        [WebInvoke(Method = "DELETE",
               ResponseFormat = WebMessageFormat.Json,
               BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "api/books/{modelYear}")]
        Car DeleteCar(string modelYear);
    
}      
  
}
