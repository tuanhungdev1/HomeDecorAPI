using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.Constants {
    public static class CloudinaryConstants {
        public static class Folders {
            public const string Products = "products";
            public const string Users = "users";
            public const string Categories = "categories";
            public const string Brand = "brands";
            public const string Supplier = "suppliers";
        }

        public static class FileTypes {
            public const string ProductImage = "prod";
            public const string UserAvatar = "avatar";
            public const string CategoryImage = "cat";
            public const string BrandImage = "brand";
            public const string Supplier = "suppl";
        }
    }
}
