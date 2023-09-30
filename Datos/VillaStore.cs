using ApiVillaC.Controllers.Models.Dto;

namespace ApiVillaC.Datos
{
    public static class VillaStore
    {

        public static List<VillaDto> VillaList = new List<VillaDto>()

        {
            new VillaDto{Id= 1, Name="Vista a la Piscina"},
            new VillaDto{Id= 2, Name="Vista a la Playa"}
        };
    }
}
