import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { NgForm } from '@angular/forms';
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
  singleFarm: Farm;
  base: string;
  addedFarm: Farm;


  /** farm ctor */
    constructor(private http: HttpClient, private farmserv: FarmService, private router: Router, @Inject('BASE_URL') baseUrl) {
      this.base = baseUrl + 'Farm';

  }

  getFarms(): any {
    this.farmserv.getFarmsList(this.base)
      .subscribe(farmList => {
        this.allFarms = farmList;
        console.log(this.allFarms);
        
      })
  }

  getFarm(farmId: number): any{
    this.farmserv.getFarm(this.base, farmId)
    .subscribe(oneFarm => {
      this.singleFarm = oneFarm;
      console.log(this.singleFarm);
    
      
    })
  }

  addFarm(form: NgForm){
    let newName = form.form.value.name;
    let newFarm: Farm = {id: null, name: newName, seeds: 100};
    this.http.post<Farm>(this.base + '/add/name=' + newFarm.name, newFarm)
    .subscribe(fList => {
      this.addedFarm = fList;
      console.log(this.addedFarm);

    })
  }
}
