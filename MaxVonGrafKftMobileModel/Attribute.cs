using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class Attribute
    {
        public int AttributeId { get; set; }
        public string KeyValue { get; set; }
        public string Type { get; set; }
        public string Module { get; set; }
        public int GroupId { get; set; }
    }

    public class AttributeGroup
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }

    public class AgreementAttribute
    {
        public int KeyValueId { get; set; }
        public int AgreementId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
    }

    public class ReservationAttribute
    {
        public int KeyValueId { get; set; }
        public int ReservationId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
    }

    public class CustomerAttribute
    {
        public int KeyValueId { get; set; }
        public int CustomerId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
    }

    public class AgreementAttributeViewModel
    {
        public int KeyValueId { get; set; }
        public int AgreementId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string KeyValue { get; set; }
        public string Type { get; set; }

        public string DisplayName { get; set; }

    }

    public class ReservationAttributeViewModel
    {
        public int KeyValueId { get; set; }
        public int ReservationId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string KeyValue { get; set; }
        public string Type { get; set; }
        public string DisplayName { get; set; }

    }

    public class CustomerAttributeViewModel
    {
        public int KeyValueId { get; set; }
        public int CustomerId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string KeyValue { get; set; }
        public string Type { get; set; }

        public string DisplayName { get; set; }

    }

    //public class AgreementAttributeReviewModel
    //{
    //    public List<Attribute> AttributeList { get; set; }
    //    public AgreementAttributeViewModel AgreementAttributes { get; set; }

    //}
    //public class ReservationAttributeReviewModel
    //{
    //    //public List<Attribute> AttributeList { get; set; }
    //    public List<ReservationAttributeViewModel> ReservationAttributes { get; set; }
    //}
}
