using DataAccessLayer.DTO;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public class ConversionsDataAccess
    {
        //Gets list of all conversions
        public List<ConversionsListDTO> GetAllConversions()
        {
            BuildChecklistContext dbContext = new BuildChecklistContext();
            var query = from c in dbContext.Conversions
                        select new ConversionsListDTO()
                        {
                            ConversionId = c.ConversionId,
                            ConversionName = c.ConversionName,
                            ConversionDescription = c.ConversionDescription,
                            IdMember1 = c.IdMember1,
                            IdMember2 = c.IdMember2,
                            IdMember3 = c.IdMember3,
                            IdMember4 = c.IdMember4,
                            CompletedStatus = c.CompletedStatus,
                            Type = c.Type
                            
                        };
            return query.ToList();
        }


        public ConversionsListDTO UpdateConversionInDB(ConversionsListDTO conversion)
        {
            BuildChecklistContext dbContext = new BuildChecklistContext();
            Conversions conversions = dbContext.Conversions.Where(c => c.ConversionId == conversion.ConversionId).FirstOrDefault();

            conversions.ConversionId = conversion.ConversionId;
            conversions.ConversionName = conversion.ConversionName;
            conversions.ConversionDescription = conversion.ConversionDescription;
            conversions.IdMember1 = conversion.IdMember1;
            conversions.IdMember2 = conversion.IdMember2;
            conversions.IdMember3 = conversion.IdMember3;
            conversions.IdMember4 = conversion.IdMember4;
            conversions.CompletedStatus = conversion.CompletedStatus;
            conversions.Type = conversion.Type;

            dbContext.SaveChanges();
            return conversion;
        }

        //public int AddConversionToDB(ConversionsListDTO conversionDTO)
        //{
        //    BuildChecklistContext dbContext = new BuildChecklistContext();
        //    Conversions conversions= new Conversions();
        //    conversions.ConversionId = conversionDTO.ConversionId;
        //    conversions.ConversionName = conversionDTO.ConversionName;
        //    conversions.ConversionDescription = conversionDTO.ConversionDescription;
        //    conversions.IdMember1 = conversionDTO.IdMember1;
        //    conversions.IdMember2 = conversionDTO.IdMember2;
        //    conversions.IdMember3 = conversionDTO.IdMember3;
        //    conversions.IdMember4 = conversionDTO.IdMember4;
        //    conversions.CompletedStatus = conversionDTO.CompletedStatus;
        //    conversions.Type = conversionDTO.Type;

        //    dbContext.SaveChanges();

        //    return conversions.ConversionId;
        //}
    }
}
