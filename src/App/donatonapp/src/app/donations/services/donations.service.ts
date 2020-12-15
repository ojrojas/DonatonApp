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
import { TypeDonation } from 'src/app/models/typedonation.model';
import { TypeIdentification } from 'src/app/models/typeidentification.model';
import { Bank } from 'src/app/models/bank.model';
import { StateMaterial } from 'src/app/models/state-material.model';


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

  loadBanks(): void {
    this.store.dispatch(fromAction.loadBanks());
  }

  loadComponentsForms(): void {
    this.loadDonationMoneys();
    this.loadDonationsPerishable();
    this.loadDonationsNonPerishable();
    this.loadTypeDonations();
    this.loadStateMaterial();
    this.loadTypeIdentification();
    this.loadBanks();
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
    this.getState().subscribe(state => {
      this.launchFormModalDonationMoney(
        donationMoney,
        state.typeDonations,
        state.typeIdentifications,
        state.banks,
        EnumsModeForms.Create,
        'Crear donación en dinero');
    }).unsubscribe();
  }

  addDonationPerishable(): void {
    const donationPerishable: DonationPerishable = null;
    this.getState().subscribe(state => {
      this.launchFormModalDonationPerishable(
        donationPerishable,
        state.typeDonations,
        state.typeIdentifications,
        EnumsModeForms.Create,
        'Crear donación en especie perecedera');
    }).unsubscribe();
  }

  addDonationNonPerishable(): void {
    const donationNonPerishable: DonationNonPerishable = null;
    this.getState().subscribe(state => {
      this.launchFormModalDonationNonPerishable(
        donationNonPerishable,
        state.typeDonations,
        state.typeIdentifications,
        state.stateMaterials,
        EnumsModeForms.Create,
        'Crear donación en especie no perecedera');
    }).unsubscribe();
  }

  launchFormModalDonationMoney(
    donationMoney: DonationMoney,
    typeDonations: TypeDonation[],
    typeIdentifications: TypeIdentification[],
    banks: Bank[],
    mode: EnumsModeForms,
    title: string
  ): void {
    this.store.dispatch(fromAction.LaunchFormModalDonationMoney({
      donationMoney,
      typeDonations,
      typeIdentifications,
      banks,
      mode,
      title
    }));
  }

  launchFormModalDonationPerishable(
    donationPerishable: DonationPerishable,
    typeDonations: TypeDonation[],
    typeIdentifications: TypeIdentification[],
    mode: EnumsModeForms,
    title: string
  ): void {
    this.store.dispatch(fromAction.LaunchFormModalDonationPerishable({
      donationPerishable,
      typeDonations,
      typeIdentifications,
      mode,
      title
    }));
  }

  launchFormModalDonationNonPerishable(
    donationNonPerishable: DonationNonPerishable,
    typeDonations: TypeDonation[],
    typeIdentifications: TypeIdentification[],
    stateMaterials: StateMaterial[],
    mode: EnumsModeForms,
    title: string
  ): void {
    this.store.dispatch(fromAction.LaunchFormModalDonationNonPerishable({
      donationNonPerishable,
      typeDonations,
      typeIdentifications,
      stateMaterials,
      mode,
      title
    }));
  }

  createDonationsMoney(donationMoney: DonationMoney): void {
    this.store.dispatch(fromAction.createDonationsMoney({ donationMoney }));
  }

  createDonationsPerishable(donationPerishable: DonationPerishable): void {
    this.store.dispatch(fromAction.createDonationsPerishable({ donationPerishable }));
  }

  createDonationsNonPerishable(donationNonPerishable: DonationNonPerishable): void {
    this.store.dispatch(fromAction.createDonationsNonPerishable({ donationNonPerishable }));
  }

}
