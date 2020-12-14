import { BaseEntity } from "./base-entity.model";
import { TypeDonation } from "./typedonation.model";
import { TypeIdentification } from "./typeidentification.model";

export interface Donation extends BaseEntity {
    typeDonation: TypeDonation;
    typeDonationId:string;
    typeIdentification: TypeIdentification;
    typeIdentificationId:string;
    identification:string;
    donor:string;
}