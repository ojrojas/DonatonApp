import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { HeaderModel } from 'src/app/models/hader.model';
import { DonationsService } from '../services/donations.service';
import { State } from '../store/donations.reducer';

@Component({
  selector: 'app-container',
  templateUrl: './container.component.html',
  styleUrls: ['./container.component.scss']
})
export class ContainerComponent implements OnInit {

  state$: Observable<State>;
  headerDonations: HeaderModel;

  constructor(private service: DonationsService) { }

  ngOnInit(): void {
    this.state$ = this.service.getState();
    this.headerDonations = this.service.getHeader();
    this.service.loadComponentsForms();
  }

}
