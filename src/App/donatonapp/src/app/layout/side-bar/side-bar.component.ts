import { Component } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/auth/services/auth.service';
import { ApplicationUser } from 'src/app/models/application-user.model';

@Component({
  selector: 'app-side-bar',
  templateUrl: './side-bar.component.html',
  styleUrls: ['./side-bar.component.scss']
})
export class SideBarComponent {

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );

  userLoginNanme = '';

  constructor(
    private breakpointObserver: BreakpointObserver,
    private authService: AuthService,
    private router: Router) {
    this.authService.getUserApp().subscribe(user => this.userLoginNanme = this.getNameUserLogin(user)).unsubscribe();
    this.router.navigate(['/home']);
  }

  logout(): void {
    window.location.href = 'login';
  }

  getNameUserLogin(userApp: ApplicationUser): string {
    return `${userApp.name} ${userApp.lastName}`;
  }

}
