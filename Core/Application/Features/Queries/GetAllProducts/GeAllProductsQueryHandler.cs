using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.GetAllProducts
{
    public class GeAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, GetAllProductsQueryResponse>
    {
        public Task<GetAllProductsQueryResponse> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            ///client tarafından gelen istek eğer listeleme ya da select işlemleri üzerinden ise bir queryrequest nesnesi oluşturularak gelen isteği
            ///queryresponse döndürecek şekilde oluşturuyoruz.
            ///request objesi queryhandler nesnesinde işlenerek queryresponse sonucunu cliente döndürür.
            ///burada gelen istek hangi entity ise o entitynin concrete yapısını IOC kullanarak constructor üzerinden çağırırız.
            ///persistance katmanı, application katmanın üst seviyesi olduğu için doğrudan bir referans yoktur. Gelen istek hangi entity ise o entitynin 
            ///application katmanında ki interfacesinede erişim sağlanamamaktadır.Bu sebep ile IOC yapılanması ile application katmanında, bir üst seviyedeki Persistance katmanında bulunan interfaceslerin concrete yapılarına constructor üzerinden ulaşılabilir.


            throw new Exception();
        
        }
    }
}
