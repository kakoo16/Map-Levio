package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.util.List;


/**
 * The persistent class for the RessourceNs database table.
 * 
 */
@Entity
@Table(name="RessourceNs")
@NamedQuery(name="RessourceN.findAll", query="SELECT r FROM RessourceN r")
public class RessourceN implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="RessourceId")
	private int ressourceId;

	@Column(name="Business_sector")
	private String business_sector;

	@Column(name="DaysoffFK")
	private int daysoffFK;

	@Column(name="First_name")
	private String first_name;

	@Column(name="HolidayFk")
	private int holidayFk;

	@Column(name="JobType")
	private String jobType;

	@Column(name="Last_name")
	private String last_name;

	@Column(name="MandateFk")
	private int mandateFk;

	@Column(name="Note")
	private float note;

	@Column(name="Organizational_ChartFk")
	private int organizational_ChartFk;

	private String picture;

	@Column(name="ProjectFk")
	private int projectFk;

	@Column(name="Salary")
	private float salary;

	@Column(name="Seniority")
	private String seniority;

	@Column(name="SkiFk")
	private int skiFk;

	private int state;

	@Column(name="Work_profil")
	private String work_profil;

	//bi-directional many-to-one association to DayOff
	@OneToMany(mappedBy="ressourceN")
	private List<DayOff> dayOffs;

	//bi-directional many-to-one association to Holiday
	@OneToMany(mappedBy="ressourceN")
	private List<Holiday> holidays;

	//bi-directional many-to-one association to Mandate
	@OneToMany(mappedBy="ressourceN")
	private List<Mandate> mandates;

	//bi-directional many-to-one association to Organizational_Chart
	@OneToMany(mappedBy="ressourceN")
	private List<Organizational_Chart> organizationalCharts;

	//bi-directional many-to-one association to Project
	@OneToMany(mappedBy="ressourceN")
	private List<Project> projects;

	//bi-directional many-to-one association to Request
	@OneToMany(mappedBy="ressourceN")
	private List<Request> requests;

	//bi-directional many-to-one association to Skill
	@OneToMany(mappedBy="ressourceN")
	private List<Skill> skills;

	public RessourceN() {
	}

	public int getRessourceId() {
		return this.ressourceId;
	}

	public void setRessourceId(int ressourceId) {
		this.ressourceId = ressourceId;
	}

	public String getBusiness_sector() {
		return this.business_sector;
	}

	public void setBusiness_sector(String business_sector) {
		this.business_sector = business_sector;
	}

	public int getDaysoffFK() {
		return this.daysoffFK;
	}

	public void setDaysoffFK(int daysoffFK) {
		this.daysoffFK = daysoffFK;
	}

	public String getFirst_name() {
		return this.first_name;
	}

	public void setFirst_name(String first_name) {
		this.first_name = first_name;
	}

	public int getHolidayFk() {
		return this.holidayFk;
	}

	public void setHolidayFk(int holidayFk) {
		this.holidayFk = holidayFk;
	}

	public String getJobType() {
		return this.jobType;
	}

	public void setJobType(String jobType) {
		this.jobType = jobType;
	}

	public String getLast_name() {
		return this.last_name;
	}

	public void setLast_name(String last_name) {
		this.last_name = last_name;
	}

	public int getMandateFk() {
		return this.mandateFk;
	}

	public void setMandateFk(int mandateFk) {
		this.mandateFk = mandateFk;
	}

	public float getNote() {
		return this.note;
	}

	public void setNote(float note) {
		this.note = note;
	}

	public int getOrganizational_ChartFk() {
		return this.organizational_ChartFk;
	}

	public void setOrganizational_ChartFk(int organizational_ChartFk) {
		this.organizational_ChartFk = organizational_ChartFk;
	}

	public String getPicture() {
		return this.picture;
	}

	public void setPicture(String picture) {
		this.picture = picture;
	}

	public int getProjectFk() {
		return this.projectFk;
	}

	public void setProjectFk(int projectFk) {
		this.projectFk = projectFk;
	}

	public float getSalary() {
		return this.salary;
	}

	public void setSalary(float salary) {
		this.salary = salary;
	}

	public String getSeniority() {
		return this.seniority;
	}

	public void setSeniority(String seniority) {
		this.seniority = seniority;
	}

	public int getSkiFk() {
		return this.skiFk;
	}

	public void setSkiFk(int skiFk) {
		this.skiFk = skiFk;
	}

	public int getState() {
		return this.state;
	}

	public void setState(int state) {
		this.state = state;
	}

	public String getWork_profil() {
		return this.work_profil;
	}

	public void setWork_profil(String work_profil) {
		this.work_profil = work_profil;
	}

	public List<DayOff> getDayOffs() {
		return this.dayOffs;
	}

	public void setDayOffs(List<DayOff> dayOffs) {
		this.dayOffs = dayOffs;
	}

	public DayOff addDayOff(DayOff dayOff) {
		getDayOffs().add(dayOff);
		dayOff.setRessourceN(this);

		return dayOff;
	}

	public DayOff removeDayOff(DayOff dayOff) {
		getDayOffs().remove(dayOff);
		dayOff.setRessourceN(null);

		return dayOff;
	}

	public List<Holiday> getHolidays() {
		return this.holidays;
	}

	public void setHolidays(List<Holiday> holidays) {
		this.holidays = holidays;
	}

	public Holiday addHoliday(Holiday holiday) {
		getHolidays().add(holiday);
		holiday.setRessourceN(this);

		return holiday;
	}

	public Holiday removeHoliday(Holiday holiday) {
		getHolidays().remove(holiday);
		holiday.setRessourceN(null);

		return holiday;
	}

	public List<Mandate> getMandates() {
		return this.mandates;
	}

	public void setMandates(List<Mandate> mandates) {
		this.mandates = mandates;
	}

	public Mandate addMandate(Mandate mandate) {
		getMandates().add(mandate);
		mandate.setRessourceN(this);

		return mandate;
	}

	public Mandate removeMandate(Mandate mandate) {
		getMandates().remove(mandate);
		mandate.setRessourceN(null);

		return mandate;
	}

	public List<Organizational_Chart> getOrganizationalCharts() {
		return this.organizationalCharts;
	}

	public void setOrganizationalCharts(List<Organizational_Chart> organizationalCharts) {
		this.organizationalCharts = organizationalCharts;
	}

	public Organizational_Chart addOrganizationalChart(Organizational_Chart organizationalChart) {
		getOrganizationalCharts().add(organizationalChart);
		organizationalChart.setRessourceN(this);

		return organizationalChart;
	}

	public Organizational_Chart removeOrganizationalChart(Organizational_Chart organizationalChart) {
		getOrganizationalCharts().remove(organizationalChart);
		organizationalChart.setRessourceN(null);

		return organizationalChart;
	}

	public List<Project> getProjects() {
		return this.projects;
	}

	public void setProjects(List<Project> projects) {
		this.projects = projects;
	}

	public Project addProject(Project project) {
		getProjects().add(project);
		project.setRessourceN(this);

		return project;
	}

	public Project removeProject(Project project) {
		getProjects().remove(project);
		project.setRessourceN(null);

		return project;
	}

	public List<Request> getRequests() {
		return this.requests;
	}

	public void setRequests(List<Request> requests) {
		this.requests = requests;
	}

	public Request addRequest(Request request) {
		getRequests().add(request);
		request.setRessourceN(this);

		return request;
	}

	public Request removeRequest(Request request) {
		getRequests().remove(request);
		request.setRessourceN(null);

		return request;
	}

	public List<Skill> getSkills() {
		return this.skills;
	}

	public void setSkills(List<Skill> skills) {
		this.skills = skills;
	}

	public Skill addSkill(Skill skill) {
		getSkills().add(skill);
		skill.setRessourceN(this);

		return skill;
	}

	public Skill removeSkill(Skill skill) {
		getSkills().remove(skill);
		skill.setRessourceN(null);

		return skill;
	}

}