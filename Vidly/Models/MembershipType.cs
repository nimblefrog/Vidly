using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public string Name { get; set; }

        //可以使用下列方式，或者enum來增加code可讀性
        public static readonly byte UnKnown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}