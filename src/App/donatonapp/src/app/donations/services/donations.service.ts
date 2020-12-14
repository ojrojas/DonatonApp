import { Injectable } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { State } from '../store/donations.reducer';
import * as fromAction from '../store/donations.actions';
import { ConfigButtons, HeaderModel } from 'src/app/models/hader.model';
import { DonationMoney } from 'src/app/models/donation-money.model';
import { DonationPerishable } from 'src/app/models/donation-perishable.model';
import { DonationNonPerishable } from 'src/app/models/donation-non-perishable.model';
import { EnumsModeForms } from 'src/app/models/enums.model';
import { Observable } from 'rxjs';
import { getStateDonations } from '../store/donations.selectors';


@Injectable({
  providedIn: 'root'
})
export class DonationsService {

  constructor(
    private store: Store<State>
  ) { }

  getState(): Observable<State> {
    return this.store.pipe(select(getStateDonations));
  }

  loadDonationMoneys(): void {
    this.store.dispatch(fromAction.loadDonationsMoney());
  }

  loadDonationsPerishable(): void {
    this.store.dispatch(fromAction.loadDonationsPerishable());
  }

  loadDonationsNonPerishable(): void {
    this.store.dispatch(fromAction.loadDonationsNonPerishable());
  }

  loadTypeDonations(): void {
    this.store.dispatch(fromAction.loadTypeDonation());
  }

  loadStateMaterial(): void {
    this.store.dispatch(fromAction.loadStateMaterial());
  }

  loadTypeIdentification(): void {
    this.store.dispatch(fromAction.loadTypeIdentification());
  }

  loadComponentsForms(): void {
    this.loadDonationMoneys();
    this.loadDonationsPerishable();
    this.loadDonationsNonPerishable();
    this.loadTypeDonations();
    this.loadStateMaterial();
    this.loadTypeIdentification();
  }


  getHeader(): HeaderModel {
    const configButtons = [
      {
        color: 'primary',
        description: 'Donación Dinero',
        action: this.addDonationMoney.bind(this),
      },
      {
        color: 'primary',
        description: 'Donación No Perecedera',
        action: this.addDonationNonPerishable.bind(this)
      },
      {
        color: 'primary',
        description: 'Donación Perecedera',
        action: this.addDonationPerishable.bind(this)
      }
    ] as ConfigButtons[];
    return {
      title: 'Donaciones',
      subtitle: 'Dashboard Donaciones',
      buttons: configButtons
    } as HeaderModel;
  }

  addDonationMoney(): void {
    const donationMoney: DonationMoney = null;
    this.launchFormModalDonationMoney(donationMoney, EnumsModeForms.Create, 'Crear donación en dinero');
  }

  addDonationPerishable(): void {
    const donationPerishable: DonationPerishable = null;
    this.launchFormModalDonationPerishable(donationPerishable, EnumsModeForms.Create, 'Crear donación en especie no perecedera');
  }

  addDonationNonPerishable(): void {
    const donationNonPerishable: DonationNonPerishable = null;
    this.launchFormModalDonationNonPerishable(donationNonPerishable, EnumsModeForms.Create, 'Crear donación en especie perecedera');
  }

  launchFormModalDonationMoney(donationMoney: DonationMoney, mode, title): void {
    this.store.dispatch(fromAction.LaunchFormModalDonationMoney({ donationMoney, mode, title }));
  }

  launchFormModalDonationPerishable(donationPerishable: DonationPerishable, mode, title): void {
    this.store.dispatch(fromAction.LaunchFormModalDonationPerishable({ donationPerishable, mode, title }));
  }

  launchFormModalDonationNonPerishable(donationNonPerishable: DonationNonPerishable, mode, title): void {
    this.store.dispatch(fromAction.LaunchFormModalDonationNonPerishable({ donationNonPerishable, mode, title }));
  }

}
