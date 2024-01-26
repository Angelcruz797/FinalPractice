namespace FinalPractice.SportDB {
    export interface ProductRow {
        ProductId?: number;
        Title?: string;
        Price?: number;
    }

    export namespace ProductRow {
        export const idProperty = 'ProductId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'SportDB.Product';
        export const lookupKey = 'SportDB.Product';

        export function getLookup(): Q.Lookup<ProductRow> {
            return Q.getLookup<ProductRow>('SportDB.Product');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ProductId = "ProductId",
            Title = "Title",
            Price = "Price"
        }
    }
}

