namespace FinalPractice.SportDB {
    export interface CustomerRow {
        CustomerId?: number;
        UserId?: number;
        Fullname?: string;
        Firstname?: string;
        Lastname?: string;
        FullUsername?: string;
        Address?: string;
        Gender?: Gender;
        Email?: string;
    }

    export namespace CustomerRow {
        export const idProperty = 'CustomerId';
        export const nameProperty = 'FullUsername';
        export const localTextPrefix = 'SportDB.Customer';
        export const lookupKey = 'SportDB.Customer';

        export function getLookup(): Q.Lookup<CustomerRow> {
            return Q.getLookup<CustomerRow>('SportDB.Customer');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Default:Customer:View';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CustomerId = "CustomerId",
            UserId = "UserId",
            Fullname = "Fullname",
            Firstname = "Firstname",
            Lastname = "Lastname",
            FullUsername = "FullUsername",
            Address = "Address",
            Gender = "Gender",
            Email = "Email"
        }
    }
}

