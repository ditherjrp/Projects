import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardTableComponent} from './dashboard-table/dashboard-table.component'


const routes: Routes = [
  {path:'dashboard-list', component: DashboardTableComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
