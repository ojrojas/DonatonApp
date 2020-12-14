import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { of } from 'rxjs';
import { catchError, concatMap, map, tap } from 'rxjs/operators';
import { RoutesApis } from 'src/app/core/apis/api.routes';
import { ApiService } from 'src/app/core/apis/api.service';
import { DonationMoney } from 'src/app/models/donation-money.model';
import { DonationNonPerishable } from 'src/app/models/donation-non-perishable.model';
import { DonationPerishable } from 'src/app/models/donation-perishable.model';
import { HorizontalPosition, VerticalPosition } from 'src/app/models/snack-bar.model';
import { StateMaterial } from 'src/app/models/state-material.model';
import { TypeDonation } from 'src/app/models/typedonation.model';
import { TypeIdentification } from 'src/app/models/typeidentification.model';
import { ModalSharedService } from 'src/app/shared/components/modal-shared/services/modal-shared.service';
import { SnackBarService } from 'src/app/shared/components/snack-bar/snack-bar.service';
import { DonationMoneyComponent } from '../components/forms/donation-money/donation-money.component';
import { DonationNonPerishableComponent } from '../components/forms/donation-non-perishable/donation-non-perishable.component';
import { DonationPerishableComponent } from '../components/forms/donation-perishable/donation-perishable.component';
import { DonationsService } from '../services/donations.service';
import * as fromActions from './donations.actions';


@Injectable()
export class DonationsEffects {

  loadDonationsMoney$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.loadDonationsMoney),
    concatMap(() => this.apiService.getAll<DonationMoney[]>(RoutesApis.donationsMoneys)
      .pipe(
        map(response => (fromActions.loadDonationsMoneySuccess({ donationMoneys: response.body }))),
        catchError((error) => of(fromActions.loadDonationsMoneyFailure({ error }))
        )))
  ));

  loadDonationsPerishable$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.loadDonationsPerishable),
    concatMap(() => this.apiService.getAll<DonationPerishable[]>(RoutesApis.donationPerishables)
      .pipe(
        map(response => (fromActions.loadDonationsPerishableSuccess({ donationPerishables: response.body }))),
        catchError((error) => of(fromActions.loadDonationsPerishableFailure({ error }))
        )))
  ));

  loadDonationsNonPerishable$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.loadDonationsNonPerishable),
    concatMap(() => this.apiService.getAll<DonationNonPerishable[]>(RoutesApis.donationNonPerishables)
      .pipe(
        map(response => (fromActions.loadDonationsNonPerishableSuccess({ donationNonPerishables: response.body }))),
        catchError((error) => of(fromActions.loadDonationsNonPerishableFailure({ error }))
        )))
  ));

  loadStateMaterial$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.loadStateMaterial),
    concatMap(() => this.apiService.getAll<StateMaterial[]>(RoutesApis.stateMaterials)
      .pipe(
        map(response => (fromActions.loadStateMaterialSuccess({ stateMaterials: response.body }))),
        catchError((error) => of(fromActions.loadStateMaterialFailure({ error }))
        )))
  ));

  loadTypeDonation$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.loadTypeDonation),
    concatMap(() => this.apiService.getAll<TypeDonation[]>(RoutesApis.typeDonations)
      .pipe(
        map(response => (fromActions.loadTypeDonationSuccess({ typeDonations: response.body }))),
        catchError((error) => of(fromActions.loadTypeDonationFailure({ error }))
        )))
  ));
  
  loadTypeIdentification$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.loadTypeIdentification),
    concatMap(() => this.apiService.getAll<TypeIdentification[]>(RoutesApis.typeIdentification)
      .pipe(
        map(response => (fromActions.loadTypeIdentificationSuccess({ typeIdentifications: response.body }))),
        catchError((error) => of(fromActions.loadTypeIdentificationFailure({ error }))
        )))
  ));

  createDonationsMoney$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.createDonationsMoney),
    concatMap((props) => this.apiService.post<DonationMoney>(props.donationMoney, RoutesApis.donationsMoneys)
      .pipe(map(response => (fromActions.createDonationsMoneySuccess({ donationMoney: response.body }))),
        catchError((error) => of(fromActions.createDonationsMoneyFailure({ error }))
        )))
  ));

  createDonationsMoneySuccess$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.createDonationsMoneySuccess),
    tap((props) => {
      this.modalServices.close();
      this.notification.createNotification(
        'Donación creada con exito',
        'Donaciones',
        3000,
        HorizontalPosition.end,
        VerticalPosition.bottom);
      this.service.loadDonationMoneys();
    })), { dispatch: false });

  createDonationsPerishable$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.createDonationsPerishable),
    concatMap((props) => this.apiService.post<DonationPerishable>(props.donationPerishable, RoutesApis.donationPerishables)
      .pipe(map(response => (fromActions.createDonationsPerishableSuccess({ donationPerishable: response.body }))),
        catchError((error) => of(fromActions.createDonationsPerishableFailure({ error }))
        )))
  ));

  createDonationsPerishableSuccess$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.createDonationsPerishableSuccess),
    tap((props) => {
      this.modalServices.close();
      this.notification.createNotification(
        'Donación creada con exito',
        'Donaciones',
        3000,
        HorizontalPosition.end,
        VerticalPosition.bottom);
      this.service.loadDonationsPerishable();
    })), { dispatch: false });

  createDonationsNonPerishable$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.createDonationsNonPerishable),
    concatMap((props) => this.apiService.post<DonationNonPerishable>(props.donationNonPerishable, RoutesApis.donationNonPerishables)
      .pipe(map(response => (fromActions.createDonationsNonPerishableSuccess({ donationNonPerishable: response.body }))),
        catchError((error) => of(fromActions.createDonationsNonPerishableFailure({ error }))
        )))
  ));

  createDonationsNonPerishableSuccess$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.createDonationsNonPerishableSuccess),
    tap((props) => {
      this.modalServices.close();
      this.notification.createNotification(
        'Donación creada con exito',
        'Donaciones',
        3000,
        HorizontalPosition.end,
        VerticalPosition.bottom);
      this.service.loadDonationsPerishable();
    })), { dispatch: false });

  LaunchFormModalDonationMoney$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.LaunchFormModalDonationMoney),
    tap((props) => this.modalServices.open({
      title: props.title,
      component: DonationMoneyComponent,
      CssStyles: {
        width: '900px'
      },
      parameters: [
        { mode: props.mode },
        { donationMoney: props.donationMoney }
      ]
    }))), { dispatch: false });


  LaunchFormModalDonationPerishable$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.LaunchFormModalDonationPerishable),
    tap((props) => this.modalServices.open({
      title: props.title,
      component: DonationPerishableComponent,
      CssStyles: {
        width: '900px'
      },
      parameters: [
        { mode: props.mode },
        { donationPerishable: props.donationPerishable }
      ]
    }))), { dispatch: false });

  LaunchFormModalDonationNonPerishable$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.LaunchFormModalDonationNonPerishable),
    tap((props) => this.modalServices.open({
      title: props.title,
      component: DonationNonPerishableComponent,
      CssStyles: {
        width: '900px'
      },
      parameters: [
        { mode: props.mode },
        { donationNonPerishable: props.donationNonPerishable }
      ]
    }))), { dispatch: false });

  constructor(
    private actions$: Actions,
    private apiService: ApiService,
    private modalServices: ModalSharedService,
    private notification: SnackBarService,
    private service: DonationsService
  ) { }

}
