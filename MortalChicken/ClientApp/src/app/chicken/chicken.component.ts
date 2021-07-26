import { HttpClient } from '@angular/common/http';
import { Component, Inject, Input } from '@angular/core';
import { Router } from '@angular/router';
import { ChickenService } from 'src/chicken.service';
import { Chicken } from 'src/chicken';
import { Farm } from 'src/farm';

@Component({
    selector: 'app-chicken',
    templateUrl: './chicken.component.html',
    styleUrls: ['./chicken.component.css'],
    providers: [ChickenService]
})
/** chicken component*/
export class ChickenComponent {
    /** chicken ctor */
    allChickens: Chicken[] = [];
    base: string = {} as string;

    constructor(private http: HttpClient, private chickenserv: ChickenService, private router: Router,  @Inject('BASE_URL') baseUrl){
        this.base = baseUrl;
        this.getChickens();
    }
        
        
        getChickens(){
            this.chickenserv.getChickens(this.base)
            .subscribe(chickList => {
                this.allChickens = chickList;
                console.log(this.allChickens)
            })
    }
}
