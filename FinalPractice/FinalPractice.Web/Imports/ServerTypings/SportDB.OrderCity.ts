namespace FinalPractice.SportDB {
    export enum OrderCity {
        none = 1,
        SantoDomingo = 2,
        Santiago = 3,
        Azua = 4,
        Samana = 5,
        Higuey = 6
    }
    Serenity.Decorators.registerEnumType(OrderCity, 'FinalPractice.SportDB.OrderCity', 'SportDB.City');
}

