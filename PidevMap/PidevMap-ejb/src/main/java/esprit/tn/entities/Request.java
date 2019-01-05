package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;


/**
 * The persistent class for the Requests database table.
 * 
 */
@Entity
@Table(name="Requests")
@NamedQuery(name="Request.findAll", query="SELECT r FROM Request r")
public class Request implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="RequestId")
	private int requestId;

	private Timestamp deposit_Date;

	@Column(name="deposit_hour")
	private Timestamp depositHour;

	@Column(name="education_scolarity")
	private String educationScolarity;

	@Column(name="end_date_mandate")
	private Timestamp endDateMandate;

	@Column(name="experience_year")
	private Timestamp experienceYear;

	@Column(name="Manager")
	private String manager;

	@Column(name="requested_profil")
	private String requestedProfil;

	@Column(name="start_date_mandate")
	private Timestamp startDateMandate;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="MyAdmin_Id")
	private AspNetUser aspNetUser1;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="MyClient_Id")
	private AspNetUser aspNetUser2;

	//bi-directional many-to-one association to AspNetUser
	@ManyToOne
	@JoinColumn(name="MyResourcee_Id")
	private AspNetUser aspNetUser3;

	//bi-directional many-to-one association to RessourceN
	@ManyToOne
	@JoinColumn(name="RessourceN_RessourceId")
	private RessourceN ressourceN;

	public Request() {
	}

	public int getRequestId() {
		return this.requestId;
	}

	public void setRequestId(int requestId) {
		this.requestId = requestId;
	}

	public Timestamp getDeposit_Date() {
		return this.deposit_Date;
	}

	public void setDeposit_Date(Timestamp deposit_Date) {
		this.deposit_Date = deposit_Date;
	}

	public Timestamp getDepositHour() {
		return this.depositHour;
	}

	public void setDepositHour(Timestamp depositHour) {
		this.depositHour = depositHour;
	}

	public String getEducationScolarity() {
		return this.educationScolarity;
	}

	public void setEducationScolarity(String educationScolarity) {
		this.educationScolarity = educationScolarity;
	}

	public Timestamp getEndDateMandate() {
		return this.endDateMandate;
	}

	public void setEndDateMandate(Timestamp endDateMandate) {
		this.endDateMandate = endDateMandate;
	}

	public Timestamp getExperienceYear() {
		return this.experienceYear;
	}

	public void setExperienceYear(Timestamp experienceYear) {
		this.experienceYear = experienceYear;
	}

	public String getManager() {
		return this.manager;
	}

	public void setManager(String manager) {
		this.manager = manager;
	}

	public String getRequestedProfil() {
		return this.requestedProfil;
	}

	public void setRequestedProfil(String requestedProfil) {
		this.requestedProfil = requestedProfil;
	}

	public Timestamp getStartDateMandate() {
		return this.startDateMandate;
	}

	public void setStartDateMandate(Timestamp startDateMandate) {
		this.startDateMandate = startDateMandate;
	}

	public AspNetUser getAspNetUser1() {
		return this.aspNetUser1;
	}

	public void setAspNetUser1(AspNetUser aspNetUser1) {
		this.aspNetUser1 = aspNetUser1;
	}

	public AspNetUser getAspNetUser2() {
		return this.aspNetUser2;
	}

	public void setAspNetUser2(AspNetUser aspNetUser2) {
		this.aspNetUser2 = aspNetUser2;
	}

	public AspNetUser getAspNetUser3() {
		return this.aspNetUser3;
	}

	public void setAspNetUser3(AspNetUser aspNetUser3) {
		this.aspNetUser3 = aspNetUser3;
	}

	public RessourceN getRessourceN() {
		return this.ressourceN;
	}

	public void setRessourceN(RessourceN ressourceN) {
		this.ressourceN = ressourceN;
	}

}