
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
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export namespace Fields {
            export declare const ProductId;
            export declare const Title;
            export declare const Price;
        }

        [
            'ProductId',
            'Title',
            'Price'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}