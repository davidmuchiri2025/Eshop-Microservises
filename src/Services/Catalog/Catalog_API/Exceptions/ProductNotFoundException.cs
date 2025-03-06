global using System;
global using System.Collections.Generic;
global using System.Linq;
using BuildingBlocks.BuildingBlocks.Exceptions;

namespace Catalog.API.Exceptions;

public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException(Guid Id) : base("Product", Id)
    {
    }
}
