import { BaseEntity } from './base-entity.model';
import { TypeIdentification } from './typeidentification.model';

export interface Donation extends BaseEntity {
    typeIdentification: TypeIdentification;
    typeIdentificationId: string;
    identification: string;
    donor: string;
}
