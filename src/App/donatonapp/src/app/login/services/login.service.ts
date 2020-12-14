import { Injectable } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { ApplicationUser } from 'src/app/models/application-user.model';
import * as fromActions from '../store/login.actions';
import { State } from '../store/login.reducer';
import { getLoginState } from '../store/login.selectors';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private store: Store<State>) { }

  login(applicationUser: ApplicationUser): void {
    this.store.dispatch(fromActions.login({ applicationUser }));
  }

  getState(): Observable<State> {
    return this.store.pipe(select(getLoginState));
  }

  getClaims(token: string): ApplicationUser {
    const userApp =  JSON.parse(atob(token.split('.')[1]));

    return {
      id: userApp.Id,
      userName: userApp.UserName,
      password: userApp.Password,
      email: userApp.Email,
      name: userApp.Name,
      lastName: userApp.LastName,
      middleName: userApp.MiddleName,
      state: userApp.State,
      createdOn: userApp.CreatedOn,
      modifiedOn: userApp.ModifiedOn,
      createdBy: userApp.CreatedBy,
      modifiedBy: userApp.ModifiedBy
    } as ApplicationUser;
  }
}
