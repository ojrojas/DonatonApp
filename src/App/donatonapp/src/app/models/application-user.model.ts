import { BaseEntity } from './base-entity.model';

export interface ApplicationUser extends BaseEntity {
  userName: string;
  password: string;
  email: string;
  name: string;
  lastName: string;
  middleName: string;
}
