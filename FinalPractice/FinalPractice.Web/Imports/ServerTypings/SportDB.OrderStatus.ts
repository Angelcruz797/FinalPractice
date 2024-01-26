namespace FinalPractice.SportDB {
    export enum OrderStatus {
        InProgress = 1,
        InToDeliver = 2,
        delivered = 3
    }
    Serenity.Decorators.registerEnumType(OrderStatus, 'FinalPractice.SportDB.OrderStatus', 'SportDB.Order');
}

