import { Component, inject, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CampaignService } from './core/services/campaign';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('EcoAct.UI');

  campaignService = inject(CampaignService);


  ngOnInit(): void {
    this.campaignService.loadCampaigns();
  }

}
