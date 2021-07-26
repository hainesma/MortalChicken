import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { Farm } from '../farm';
import { FarmService } from '../farm.service';

@Component({
    selector: 'app-farm',
    templateUrl: './farm.component.html',
  styleUrls: ['./farm.component.css'],
    providers: [FarmService]
})
/** farm component*/
export class FarmComponent {
  allFarms: Farm[] = [];
  base: string = {} as string;

  /** farm ctor */
    constructor(private http: HttpClient, private farmserv: FarmService, private router: Router, @Inject('BASE_URL') baseUrl) {
      this.base = baseUrl;
      this.getFarms();
  }

  getFarms() {
    this.farmserv.getFarmsList(this.base)
      .subscribe(farmList => {
        this.allFarms = farmList;
        console.log(this.allFarms);
      })
  }
}
