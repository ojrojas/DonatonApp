import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { ChartDataSets, ChartOptions, ChartPoint, ChartType } from 'chart.js';
import { Color, Label } from 'ng2-charts';
import { DonationMoney } from 'src/app/models/donation-money.model';
import { DonationNonPerishable } from 'src/app/models/donation-non-perishable.model';
import { DonationPerishable } from 'src/app/models/donation-perishable.model';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnChanges {
  @Input() donationMoneys: DonationMoney[];
  @Input() donationPerishables: DonationPerishable[];
  @Input() donationNonPerishables: DonationNonPerishable[];

  public lineChartData: ChartDataSets[] = [];

  public lineChartLabels: Label[] = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Etc'];
  public lineChartOptions: ChartOptions = {
    responsive: true,
  };
  public lineChartColors: Color[] = [
    {
      borderColor: 'black',
      backgroundColor: 'rgba(255,0,0,0.3)',
    },
  ];
  public lineChartLegend = true;
  public lineChartType: ChartType = 'line';
  public lineChartPlugins = [];

  constructor() { }
  ngOnChanges(changes: SimpleChanges): void {
    this.lineChartData = [
      { data: [this.donationMoneys.length], label: 'Dinero' },
      { data: [this.donationPerishables.length], label: 'Perecederas' },
      { data: [this.donationNonPerishables.length], label: 'No Pedecederas' }
    ];
  }


}
