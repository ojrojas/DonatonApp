import { BaseEntity } from './base-entity.model';
import { Book } from './books.model';

export interface Author extends BaseEntity {
    name: string;
    lastName: string;
    books: Book[];
}




