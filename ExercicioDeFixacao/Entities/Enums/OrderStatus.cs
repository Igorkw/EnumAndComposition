using System;
namespace ExercicioDeFixacao.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPaymet = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
