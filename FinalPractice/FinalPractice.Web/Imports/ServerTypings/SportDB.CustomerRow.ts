namespace FinalPractice.SportDB {
    export interface CustomerRow {
        CustomerId?: number;
        Fullname?: string;
        Firstname?: string;
        Lastname?: string;
        Gender?: Gender;
        Email?: string;
    }

    export namespace CustomerRow {
        export const idProperty = 'CustomerId';
        export const nameProperty = 'Fullname';
        export const localTextPrefix = 'SportDB.Customer';
        export const lookupKey = 'SportDB.Customer';

        export function getLookup(): Q.Lookup<CustomerRow> {
            return Q.getLookup<CustomerRow>('SportDB.Customer');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CustomerId = "CustomerId",
            Fullname = "Fullname",
            Firstname = "Firstname",
            Lastname = "Lastname",
            Gender = "Gender",
            Email = "Email"
        }
    }
}

