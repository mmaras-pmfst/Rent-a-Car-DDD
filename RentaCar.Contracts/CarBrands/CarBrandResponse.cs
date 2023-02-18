using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Contracts.CarBrands
{
    public record CarBrandResponse(
        Guid Id,
        string Name,
        List<CarModelResponse> CarModels);

    public record CarModelResponse(
        Guid Id,
        string Name,
        Guid CarCategoryId);
}
