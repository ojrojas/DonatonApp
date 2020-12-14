import { BaseEntity } from './base-entity.model';
import { Eps } from './eps.model';
import { TypeIdentification } from './typeidentification.model';

export interface User extends BaseEntity {
    name: string;
    middleName: string;
    lastName: string;
    typeIdentification: TypeIdentification;
    typeIdentificationId: string;
    identification: number;
    cellPhone: string;
    address: string;
    eps: Eps;
    epsId: string;
    pictureUri: string;
    pictureBase64: string;
    pictureName: string;
}
