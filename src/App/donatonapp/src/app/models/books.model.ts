import { AuthorsEffects } from '../authors/store/authors.effects';
import { Author } from './authors.model';
import { AuthorsBooks } from './authorsbooks.model';
import { BaseEntity } from './base-entity.model';
import { Editorial } from './editorilas.model';

export interface Book extends BaseEntity {
    titulo: string;
    sipnosis: string;
    pages: number;
    editorialId: string;
    editorial: Editorial;
    authorId: string;
    authorsBooks: AuthorsBooks[];
}
