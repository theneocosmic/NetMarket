using Core.Entities;

namespace Core.Specifications
{
    public class ProductoForCountingSpecification : BaseSpecification<Producto>
    {
        public ProductoForCountingSpecification(ProductSpecificationParams productoParams)
           : base(x =>
           (string.IsNullOrEmpty(productoParams.Search) || x.Nombre.Contains(productoParams.Search)) &&
           (!productoParams.Marca.HasValue || x.MarcaId == productoParams.Marca) &&
           (!productoParams.Categoria.HasValue || x.CategoriaId == productoParams.Categoria)
           )
        {

        }
    }
}
