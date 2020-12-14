import { Author } from './authors.model';
import { Book } from './books.model';

export interface AuthorsBooks {
    id: string;
    author: Author;
    authorId: string;
    bookId: string;
    book: Book;
}
