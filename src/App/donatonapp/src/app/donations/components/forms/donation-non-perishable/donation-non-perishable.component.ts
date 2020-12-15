import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/auth/services/auth.service';
import { DonationsService } from 'src/app/donations/services/donations.service';
import { ApplicationUser } from 'src/app/models/application-user.model';
import { DonationNonPerishable } from 'src/app/models/donation-non-perishable.model';
import { EnumsModeForms } from 'src/app/models/enums.model';
import { StateMaterial } from 'src/app/models/state-material.model';
import { TypeDonation } from 'src/app/models/typedonation.model';
import { TypeIdentification } from 'src/app/models/typeidentification.model';
import { ModalSharedService } from 'src/app/shared/components/modal-shared/services/modal-shared.service';

@Component({
  selector: 'app-donation-non-perishable',
  templateUrl: './donation-non-perishable.component.html',
  styleUrls: ['./donation-non-perishable.component.scss']
})
export class DonationNonPerishableComponent implements OnInit {
  @Input() donationNonPerishable: DonationNonPerishable;
  @Input() mode: EnumsModeForms;
  @Input() typeIdentifications: TypeIdentification[];
  @Input() typeDonations: TypeDonation[];
  @Input() stateMaterials: StateMaterial[];

  form: FormGroup;
  userApp: ApplicationUser;

  constructor(
    private modalServices: ModalSharedService,
    private fb: FormBuilder,
    private service: DonationsService,
    private authService: AuthService
  ) { }

  ngOnInit(): void {
    this.authService.getUserApp().subscribe(result => this.userApp = result).unsubscribe();
    switch (this.mode) {
      case EnumsModeForms.Create:
        this.createForm();
        break;
      default:
        break;
    }
  }

  createForm(): void {
    this.form = this.fb.group({

      address: new FormControl({ value: null, disabled: false }, Validators.required),
      city: new FormControl({ value: null, disabled: false }, Validators.required),
      contactNumber: new FormControl({ value: null, disabled: false }, Validators.required),
      dateExpiration: new FormControl({ value: null, disabled: false }, Validators.required),
      deliveryName: new FormControl({ value: null, disabled: false }, Validators.required),
      deliveryTime: new FormControl({ value: null, disabled: false }, Validators.required),
      description: new FormControl({ value: null, disabled: false }, Validators.required),
      donor: new FormControl({ value: null, disabled: false }, Validators.required),
      identification: new FormControl({ value: null, disabled: false }, Validators.required),
      stateMaterialId: new FormControl({ value: null, disabled: false }, Validators.required),
      typeIdentificationId: new FormControl({ value: null, disabled: false }, Validators.required),
      weight: new FormControl({ value: null, disabled: false }, Validators.required),
    });
  }

  close(): void {
    this.modalServices.close();
  }

  submit(): void {
    debugger;
    if (this.form.valid) {
      switch (this.mode) {
        case EnumsModeForms.Create:
          this.service.createDonationsNonPerishable(this.sendValueCreate());
          break;
        default:
          break;
      }
    } else {
      this.markValidityForm();
    }
  }

  sendValueCreate(): DonationNonPerishable {
    return {
      typeIdentificationId: this.form.value.typeIdentificationId,
      identification: this.form.value.identification,
      donor: this.form.value.donor,
      state: true,
      address: this.form.value.address,
      city: this.form.value.city,
      contactNumber: this.form.value.contactNumber,
      deliveryName: this.form.value.deliveryName,
      deliveryTime: this.form.value.deliveryTime,
      description: this.form.value.description,
      weight: this.form.value.weight,
      stateMaterialId: this.form.value.stateMaterialId,
      createdBy: this.userApp.id,
      createdOn: new Date()
    } as DonationNonPerishable;
  }

  markValidityForm(): void {
    for (const control in this.form.controls) {
      this.form.controls[control].markAsDirty();
      this.form.controls[control].markAsTouched();
    }
  }
}
